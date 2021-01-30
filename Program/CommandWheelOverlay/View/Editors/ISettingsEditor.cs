using CommandWheelOverlay.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View.Editors
{
    public interface ISettingsEditor
    {
        IUserSettings EditSettings(IUserSettings userSettingsCopy);
    }
}
