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
        public IWheel SubWheel { get; set; } = null;
        public IWheelAction Action { get; set; } = null;

        public object Clone()
        {
            var clone = (WheelButton)MemberwiseClone();
            clone.Action = (IWheelAction)Action.Clone();
            return clone;
        }

        public SimplifiedWheelButton Simplify(IList<IWheel> wheels)
        {
            return new SimplifiedWheelButton(Label, ImgPath, wheels.IndexOf(SubWheel), Action.Simplify());
        }
    }
}
