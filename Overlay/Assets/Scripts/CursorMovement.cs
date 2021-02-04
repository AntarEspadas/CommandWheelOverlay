using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Linearstar.Windows.RawInput;
using UnityEngine;
using CommandWheelOverlay.Connection;
using CommandWheelOverlay.View;
using CommandWheelOverlay.Input;
using CommandWheelOverlay.Settings;

public class CursorMovement : MonoBehaviour
{
    public RectTransform constraint;
    public float sensitivity;
    private static Vector2 movement = new Vector2(0, 0);
    private TcpOverlayController controller;
    // Start is called before the first frame update

    void Start()
    {
        Cursor.visible = false;
        OverlayView view = new OverlayView(sensitivity);
        controller = new TcpOverlayController(view, 7777);
#if !UNITY_EDITOR
        controller.Connect();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        var rect = constraint.rect;

        Vector3 pos = transform.localPosition;

#if UNITY_EDITOR
        movement.x += Input.GetAxis("Mouse X") * sensitivity * 10;
        movement.y += Input.GetAxis("Mouse Y") * sensitivity * 10;
#endif

        float x = pos.x + movement.x;
        float y = pos.y + movement.y;
        pos.x = Mathf.Clamp(x, rect.width / -2, rect.width / 2);
        pos.y = Mathf.Clamp(y, rect.height / -2, rect.height / 2);

        transform.localPosition = pos;
        movement.x = 0;
        movement.y = 0;

    }

    class OverlayView : IOverlayView
    {
        private float sensitivity;
        public OverlayView(float sensitivity)
        {
            this.sensitivity = sensitivity;
        }

        public void Hide()
        {
            throw new System.NotImplementedException();
        }

        public void MoveLeft()
        {
            throw new System.NotImplementedException();
        }

        public void MoveRight()
        {
            throw new System.NotImplementedException();
        }

        public void SendInput(MouseInput input)
        {
        }

        public void SendMouseMovement(int[] deltas)
        {
            movement.x += deltas[0] * sensitivity / 4;
            movement.y -= deltas[1] * sensitivity / 4;
        }

        public void Show()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateElements(SimplifiedWheelElements elements)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSettings(IUserSettings settings)
        {
            throw new System.NotImplementedException();
        }
    }
}
