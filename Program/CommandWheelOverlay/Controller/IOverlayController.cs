using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Controller
{
    public interface IOverlayController
    {
        IWheelElements Elements { get; }
        void PerformAction(int actionIndex);
        void UpdateSettings();
        void UpdateDisplay();
    }
}
