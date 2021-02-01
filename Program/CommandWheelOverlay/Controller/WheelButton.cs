using CommandWheelOverlay.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Controller
{
    public class WheelButton : IWheelButton
    {
        public string Label { get; set; } = "Button";
        public string ImgPath { get; set; } = null;
        public IWheelAction Action { get; set; } = null;

        public object Clone()
        {
            var clone = (WheelButton)MemberwiseClone();
            clone.Action = Action is null ? default : (IWheelAction)Action.Clone();
            return clone;
        }

        public SimplifiedWheelButton Simplify(IList<IWheel> wheels)
        {
            SimplifiedWheelAction action = Action is null ? default : Action.Simplify(wheels);
            return new SimplifiedWheelButton(Label, ImgPath, action);
        }
    }
}
