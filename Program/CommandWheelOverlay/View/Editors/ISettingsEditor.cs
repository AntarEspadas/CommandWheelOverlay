using CommandWheelOverlay.Input;
using CommandWheelOverlay.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View.Editors
{
    public interface ISettingsEditor
    {
        bool EditSettings(IUserSettings userSettings, IInputHandler inputHandler);
    }
}
