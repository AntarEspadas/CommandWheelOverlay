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
    public CursorMovement cursorMovement;
    private TcpOverlayController controller;
    private ManualResetEvent resetEvent = new ManualResetEvent(true);
    private bool shown;
    private bool startShowing;
    private bool startHiding;

    public CursorMovement cursor;
    public Wheel wheelPrefab;
    private Wheel[] wheels;
    private int startupWheel;

    private void Start()
    {
        controller = new TcpOverlayController(this, 7777);
#if !UNITY_EDITOR
        controller.Connect();
#endif
    }

    void Update()
    {
        if (startHiding)
        {
            shown = false;
            Overlay.Hide();
            startHiding = false;
        }
        resetEvent.WaitOne();
        if (startShowing)
        {
            shown = true;
            cursorMovement.transform.localPosition = new Vector3();
            Overlay.Show();
            startShowing = false;
        }
    }

    public void Hide()
    {
        startHiding = true;
        resetEvent.Reset();
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
        lock (wheels)
        {
            var canvas = transform.parent.Find("Canvas");
            wheels = new Wheel[elements.Wheels.Length];
            startupWheel = elements.StartupWheel;
            for (int i = 0; i < wheels.Length; i++)
            {
                var wheel = Instantiate(wheelPrefab, canvas);
                wheels[i] = wheel;
            }
        }
    }

    public void UpdateSettings(IUserSettings settings)
    {
        throw new System.NotImplementedException();
    }
}
