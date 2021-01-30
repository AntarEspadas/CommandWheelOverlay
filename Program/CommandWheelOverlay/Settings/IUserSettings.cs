using CommandWheelOverlay.View.Editors;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Settings
{
    public interface IUserSettings : ICloneable
    {
        ISettingsEditor Editor { get; set; }
    }
}
