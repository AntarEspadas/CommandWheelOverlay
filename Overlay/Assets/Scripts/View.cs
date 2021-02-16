using CommandWheelOverlay.Connection;
using CommandWheelOverlay.Controller;
using CommandWheelOverlay.Settings;
using CommandWheelOverlay.View;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class View : MonoBehaviour, IOverlayView
{
    public Canvas canvas;
    public CursorMovement cursorMovement;
    public CursorHighlight cursorHighlight;
    public Wheel wheelPrefab;


    private TcpOverlayController controller;
    private ManualResetEvent resetEvent = new ManualResetEvent(true);


    private bool shown;
    private bool startShowing;
    private bool startHiding = true;
    private bool moveLeft;
    private bool moveRight;

    private SimplifiedWheelElements? pendingElements;

    private Wheel[] wheels;
    private int startupWheel;
    private int currentWheel;

    private void Start()
    {
        controller = new TcpOverlayController(this, 7777);
//#if !UNITY_EDITOR
        controller.Connect();
//#endif
    }

    void Update()
    {
        if (startHiding)
        {
            HideOverlay();
            startHiding = false;
            return;
        }

        if (pendingElements.HasValue)
        {
            CreateWheels(pendingElements.Value);
            pendingElements = null;
            return;
        }

        if (startShowing)
        {
            ShowOverlay();
            startShowing = false;
            return;
        }

        if (moveLeft)
        {
            Move(0, -1);
            moveLeft = false;
            return;
        }

        if (moveRight)
        {
            Move(wheels.Length - 1, 1);
            moveRight = false;
            return;
        }
    }

    private void Move(int cap, int direction)
    {
        if (currentWheel == cap) return;
        var oldWheel = wheels[currentWheel];
        oldWheel.ForceUnhighlightAll();
        oldWheel.FadeOut(-direction);
        currentWheel += Mathf.Clamp(direction, -1, 1);
        var newWheel = wheels[currentWheel];
        newWheel.FadeIn();
        cursorHighlight.wheel = newWheel;
    }

    private void CreateWheels(SimplifiedWheelElements elements)
    {
        if (wheels != null)
        {
            foreach (Wheel wheel in wheels)
            {
                Destroy(wheel.gameObject);
            }
        }
        if (elements.StartupWheel < 0) return;
        wheels = new Wheel[elements.Wheels.Length];
        startupWheel = elements.StartupWheel;
        for (int i = 0; i < wheels.Length; i++)
        {
            var wheel = Instantiate(wheelPrefab, canvas.transform);
            wheels[i] = wheel;
            wheel.Template = elements.Wheels[i];
            wheel.ButtonTemplates = elements.Buttons;
        }
        ResetWheelPositions();
        cursorHighlight.wheel = wheels[startupWheel];
        cursorMovement.transform.SetAsLastSibling();
    }

    private void ResetWheelPositions()
    {
        for (int i = 0; i < wheels.Length; i++)
        {
            var wheel = wheels[i];
            var position = new Vector3(50, 0);
            if (i < startupWheel)
            {
                wheel.transform.localPosition = -position;
            }
            else if (i > startupWheel)
            {
                wheel.transform.localPosition = position;
            }
            else
            {
                wheel.transform.localPosition = new Vector3(0, 0);
            }
        }
    }

    private void HideOverlay()
    {
        if (wheels != null && startupWheel >= 0)
        {
            int highlightedButton = cursorHighlight.GetHighlightedButton();
            if (highlightedButton >= 0)
            {
                Debug.Log("Action");
                controller.PerformAction(highlightedButton);
            }
            wheels[currentWheel].ForceUnhighlightAll();
            wheels[currentWheel].Hide();
        }
        cursorMovement.transform.localPosition = new Vector3(0, 0);
        shown = false;
        Overlay.Hide();
        resetEvent.Reset();
#if !UNITY_EDITOR
        resetEvent.WaitOne(); 
#endif
    }

    private void ShowOverlay()
    {
        if (wheels != null && startupWheel >= 0)
        {
            ResetWheelPositions();
            currentWheel = startupWheel;
            wheels[startupWheel].Show();
            cursorHighlight.wheel = wheels[startupWheel];
        }
        cursorMovement.transform.localPosition = new Vector3(0, 0);
        shown = true;
        Overlay.Show();
    }

    public void Hide()
    {
        startHiding = true;
    }

    public void MoveLeft()
    {
        moveLeft = true;
    }

    public void MoveRight()
    {
        moveRight = true;
    }

    public void SendMouseMovement(int[] deltas)
    {
        if (shown) cursorMovement.AddMovement(new Vector2(deltas[0], -deltas[1]));
    }

    public void Show()
    {
        startShowing = true;
        resetEvent.Set();
    }

    public void UpdateElements(SimplifiedWheelElements elements)
    {
        pendingElements = elements;
    }

    public void UpdateSettings(IUserSettings settings)
    {
        throw new System.NotImplementedException();
    }
}
