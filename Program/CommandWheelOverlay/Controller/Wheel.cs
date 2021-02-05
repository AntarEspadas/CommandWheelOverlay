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
        public Color BgColor { get; set; } = Color.Black;
        public string Label { get; set; } = "Wheel";

        public object Clone()
        {
            var clone = (Wheel)MemberwiseClone();
            clone.Buttons = new List<IWheelButton>(Buttons);
            return clone;
        }
    }
}
