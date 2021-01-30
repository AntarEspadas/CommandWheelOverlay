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
            client.Connect(IPAddress.Parse("127.0.0.1"), port);
            bridge = new Bridge(client.GetStream(), controller);
        }

        public void SendInput(KeyboardInput input)
        {
            Validate();
            bridge.Pass(parameters: input);
        }

        public void SendInput(MouseInput input)
        {
            Validate();
            bridge.Pass(parameters: input);
        }

        public void UpdateElements(ISimplifiedWheelElements elements)
        {
            Validate();
            bridge.Pass(parameters: elements);
        }

        public void UpdateSettings(IUserSettings settings)
        {
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
