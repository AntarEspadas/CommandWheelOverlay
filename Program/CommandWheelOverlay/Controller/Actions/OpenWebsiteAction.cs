using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Controller.Actions
{
    public class OpenWebsiteAction : IWheelAction
    {
        public string Url { get; set; }

        public IWheelAction Clone(IWheelElements elements)
        {
            return (IWheelAction)MemberwiseClone();
        }

        public void Perform()
        {
            System.Diagnostics.Process.Start(Url);
        }
    }
}
