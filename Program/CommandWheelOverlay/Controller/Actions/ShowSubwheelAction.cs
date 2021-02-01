using CommandWheelOverlay.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Controller.Actions
{
    public class ShowSubwheelAction : IWheelAction
    {
        public IWheel SubWheel { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Perform()
        {
            throw new NotSupportedException();
        }

        public SimplifiedWheelAction Simplify(IList<IWheel> wheels)
        {
            int wheelIndex = SubWheel is null ? -1 : wheels.IndexOf(SubWheel);
            return new SimplifiedWheelAction(WheelActionType.DisplaySubwheel, wheelIndex);
        }
    }
}
