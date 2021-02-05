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

        public IWheelButton Clone(IWheelElements elements)
        {
            var clone = (WheelButton)MemberwiseClone();
            clone.Action = Action?.Clone(elements);
            elements.Buttons.Add(clone);
            return clone;
        }
    }
}
