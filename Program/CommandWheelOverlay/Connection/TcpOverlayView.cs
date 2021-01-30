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
#if NO_CONNECTION || UNITY_EDITOR
            return;
#endif
            client.Connect(IPAddress.Parse("127.0.0.1"), port);
            bridge = new Bridge(client.GetStream(), controller);
        }

        public void SendInput(KeyboardInput input)
        {
#if NO_CONNECTION || UNITY_EDITOR
            return;
#endif
            Validate();
            bridge.Pass(parameters: input);
        }

        public void SendInput(MouseInput input)
        {
#if NO_CONNECTION || UNITY_EDITOR
            return;
#endif
            Validate();
            bridge.Pass(parameters: input);
        }

        public void UpdateElements(ISimplifiedWheelElements elements)
        {
#if NO_CONNECTION || UNITY_EDITOR
            return;
#endif
            Validate();
            bridge.Pass(parameters: elements);
        }

        public void UpdateSettings(IUserSettings settings)
        {
#if NO_CONNECTION || UNITY_EDITOR
            return;
#endif
            Validate();
            bridge.Pass(parameters: settings);
        }

        private void Validate()
        {
            if (!client.Connected)
                throw new ConnectionClosedException($"Connection to port {port} is closed");
        }
    }
}
