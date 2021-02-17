using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CommandWheelOverlay.Controller.Actions
{
    public class OpenSteamAppAction : IWheelAction
    {
        public int AppId { get; set; }

        public IWheelAction Clone(IWheelElements elements)
        {
            return (IWheelAction)MemberwiseClone();
        }

        public void Perform()
        {
            Process.Start($"steam://rungameid/{AppId}");
        }
    }
}
