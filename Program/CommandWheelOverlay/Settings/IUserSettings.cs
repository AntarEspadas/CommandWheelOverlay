using CommandWheelOverlay.View.Editors;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Settings
{
    public interface IUserSettings : ICloneable
    {
        ISettingsEditor Editor { get; set; }
        IList<int> ShowHotkey { get; set; }
        IList<int> MoveLeftHotkey { get; set; }
        IList<int> MoveRightHotkey { get; set; }
        
        float Sensitivity { get; set; }
        int Port { get; set; }
    }
}
