using CommandWheelOverlay.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Controller
{
    public interface IOverlayController
    {
        IOverlayView View { get; set; }
        IElementsEditor ElementsEditor { get; set; }
        ISettingsEditor SettingsEditor { get; set; }

        IWheelElements Elements { get; }
        void PerformAction(int actionIndex);
        void UpdateSettings();
        void UpdateElements();
    }
}
