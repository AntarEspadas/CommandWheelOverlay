using CommandWheelOverlay.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Controller.Actions
{
    public class ShowSubwheelAction : IWheelAction
    {
        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Perform()
        {
            throw new NotSupportedException();
        }

        public SimplifiedWheelAction Simplify()
        {
            return new SimplifiedWheelAction(WheelActionType.DisplaySubwheel);
        }
    }
}
