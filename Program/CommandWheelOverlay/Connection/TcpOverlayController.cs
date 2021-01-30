using CommandWheelOverlay.Controller;
using CommandWheelOverlay.Settings;
using CommandWheelOverlay.View;
using CommandWheelOverlay.View.Editors;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CommandWheelOverlay.Connection
{
    public class TcpOverlayController : IOverlayController
    {
        IWheelElements IOverlayController.Elements => throw new NotImplementedException();

        IOverlayView IOverlayController.View { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        IUserSettings IOverlayController.Settings => throw new NotImplementedException();

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
#if NO_CONNECTION
            return;
#endif
            listener.Start();
            Socket client = listener.AcceptSocket();
            bridge = new Bridge(new NetworkStream(client), view);
        }
        public void PerformAction(int actionIndex)
        {
#if NO_CONNECTION
            return;
#endif
            bridge.Pass(parameters: actionIndex);
        }

        void IOverlayController.UpdateElements()
        {
#if NO_CONNECTION
            return;
#endif
            throw new NotImplementedException();
        }

        void IOverlayController.UpdateSettings()
        {
#if NO_CONNECTION
            return;
#endif
            throw new NotImplementedException();
        }
    }
}
