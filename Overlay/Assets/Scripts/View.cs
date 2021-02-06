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
    private bool startHiding;

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
    }

    private void CreateWheels(SimplifiedWheelElements elements)
    {
        wheels = new Wheel[elements.Wheels.Length];
        startupWheel = elements.StartupWheel;
        for (int i = 0; i < wheels.Length; i++)
        {
            var wheel = Instantiate(wheelPrefab, canvas.transform);
            wheels[i] = wheel;
            wheel.Template = elements.Wheels[i];
            wheel.ButtonTemplates = elements.Buttons;
        }
        cursorHighlight.wheel = wheels[startupWheel];
    }

    private void HideOverlay()
    {
        if (wheels != null && startupWheel >= 0)
        {
            wheels[currentWheel].gameObject.SetActive(false);
            int highlightedButton = cursorHighlight.GetHighlightedButton();
            if (highlightedButton >= 0)
            {
                Debug.Log("Action");
                controller.PerformAction(highlightedButton);
            }
        }
        shown = false;
        Overlay.Hide();
        resetEvent.Reset();
        resetEvent.WaitOne();
    }

    private void ShowOverlay()
    {
        if (wheels != null && startupWheel >= 0)
        {
            currentWheel = startupWheel;
            wheels[startupWheel].gameObject.SetActive(true);
        }
        shown = true;
        cursorMovement.transform.localPosition = new Vector3();
        Overlay.Show();
    }

    public void Hide()
    {
        startHiding = true;
    }

    public void MoveLeft()
    {
        throw new System.NotImplementedException();
    }

    public void MoveRight()
    {
        throw new System.NotImplementedException();
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
