using CommandWheelOverlay.Controller;
using CommandWheelOverlay.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Model
{
    public interface IOverlayModel
    {
        IWheelElements GetElements();
        bool SaveElements(IWheelElements elements);

        IUserSettings GetSettings();
        bool SaveSettings(IUserSettings settings);
    }
}
