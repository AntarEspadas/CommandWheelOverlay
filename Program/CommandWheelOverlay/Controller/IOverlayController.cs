using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Controller
{
    public interface IOverlayController
    {
        void PerformAction(int actionIndex);
    }
}
