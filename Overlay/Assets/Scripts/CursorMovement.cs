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

        Vector3 pos = transform.position;

#if UNITY_EDITOR
        movement.x += Input.GetAxis("Mouse X") * sensitivity * 10;
        movement.y += Input.GetAxis("Mouse Y") * sensitivity * 10;
#endif

        float xMin = rect.x + rect.width / 2;
        float xMax = rect.x - rect.width / 2;
        xMax *= -1;
        float yMin = rect.y + rect.height / 2;
        float yMax = rect.y - rect.height / 2;
        yMax *= -1;
        float x = pos.x + movement.x;
        float y = pos.y + movement.y;
        pos.x = Mathf.Clamp(x, xMin, xMax);
        pos.y = Mathf.Clamp(y, yMin, yMax);

        transform.position = pos;
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
        public void SendInput(KeyboardInput input)
        {
            return;
        }

        public void SendInput(MouseInput input)
        {
            movement.x += input.LastX * sensitivity;
            movement.y -= input.LastY * sensitivity;
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
