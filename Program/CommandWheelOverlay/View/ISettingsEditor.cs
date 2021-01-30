using CommandWheelOverlay.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View
{
    public interface ISettingsEditor
    {
        IUserSettings EditSettings(IUserSettings userSettingsCopy);
    }
}
