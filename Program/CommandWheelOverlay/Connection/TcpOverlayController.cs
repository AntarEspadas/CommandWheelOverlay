using CommandWheelOverlay.Controller;
using CommandWheelOverlay.View;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CommandWheelOverlay.Connection
{
    public class TcpOverlayController : IOverlayController
    {
        private IOverlayView view;
        TcpListener listener;
        Bridge bridge;
        public TcpOverlayController(IOverlayView view, int port)
        {
            this.view = view;
            listener = new TcpListener(IPAddress.Any, port);
        }
        public void Connect()
        {
            listener.Start();
            Socket client = listener.AcceptSocket();
            bridge = new Bridge(new NetworkStream(client), view);
        }
        public void PerformAction(int actionIndex)
        {
            bridge.Pass(parameters: actionIndex);
        }
    }
}
