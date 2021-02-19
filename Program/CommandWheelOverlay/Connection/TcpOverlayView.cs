using CommandWheelOverlay.Controller;
using CommandWheelOverlay.Input;
using CommandWheelOverlay.Settings;
using CommandWheelOverlay.View;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CommandWheelOverlay.Connection
{
    public class TcpOverlayView : IOverlayView
    {
        private readonly TcpClient client;

        private IOverlayController controller;
        private int port;
        private Bridge bridge;
        public TcpOverlayView(IOverlayController controller, int port)
        {
            this.controller = controller;
            this.port = port;
            client = new TcpClient();
        }
        public void Connect()
        {
#if NO_CONNECTION
            return;
#endif
            client.Connect(IPAddress.Parse("127.0.0.1"), port);
            bridge = new Bridge(client.GetStream(), controller);
        }

        public void Hide()
        {
#if NO_CONNECTION
            return;
#endif
            bridge.Pass();
        }

        public void MoveLeft()
        {
#if NO_CONNECTION
            return;
#endif
            bridge.Pass();
        }

        public void MoveRight()
        {
#if NO_CONNECTION
            return;
#endif
            bridge.Pass();
        }

        public void SendMouseMovement(int[] deltas)
        {
#if NO_CONNECTION
            return;
#endif
            bridge.Pass(parameters: deltas);
        }

        public void SetSensitivity(float sensitivity)
        {
            bridge.Pass(parameters: sensitivity);
        }

        public void Show()
        {
#if NO_CONNECTION
            return;
#endif
            bridge.Pass();
        }

        public void UpdateElements(SimplifiedWheelElements elements)
        {
#if NO_CONNECTION
            return;
#endif
            Validate();
            bridge.Pass(parameters: elements);
        }

        private void Validate()
        {
            if (!client.Connected)
                throw new ConnectionClosedException($"Connection to port {port} is closed");
        }
    }
}
