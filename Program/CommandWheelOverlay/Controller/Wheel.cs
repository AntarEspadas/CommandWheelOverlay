using CommandWheelOverlay.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CommandWheelOverlay.Controller
{
    public class Wheel : IWheel
    {
        public IList<IWheelButton> Buttons { get; set; } = new List<IWheelButton>();
        public Color AccentColor { get; set; } = Color.White;
        public Color BgColor { get; set; } = Color.FromArgb(128, 25, 140, 210);
        public string Label { get; set; } = "Wheel";

        public IWheel Clone(IWheelElements elements)
        {
            var clone = (Wheel)MemberwiseClone();
            clone.Buttons = Buttons.Select(button => button.Clone(elements)).ToList();
            return clone;
        }
    }
}
