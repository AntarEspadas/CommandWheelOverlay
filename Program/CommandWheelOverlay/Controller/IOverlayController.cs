using CommandWheelOverlay.Settings;
using CommandWheelOverlay.View;
using CommandWheelOverlay.View.Editors;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Controller
{
    public interface IOverlayController
    {
        IOverlayView View { get; set; }
        ISettingsEditor SettingsEditor { get; set; }

        IWheelElements Elements { get; }
        IUserSettings Settings { get; }
        void PerformAction(int actionIndex);
        void UpdateSettings();
        void UpdateElements();
    }
}
