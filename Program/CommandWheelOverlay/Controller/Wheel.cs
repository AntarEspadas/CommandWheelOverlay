using CommandWheelOverlay.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CommandWheelOverlay.Controller
{
    class Wheel : IWheel
    {
        public IList<IWheelButton> Buttons { get; set; }
        public Color AccentColor { get; set; }
        public Color BgColor { get; set; }

        public SimplifiedWheel Simplify(IList<IWheelButton> buttons)
        {
            var buttonsDict = new Dictionary<IWheelButton, int>();
            for (int i = 0; i < buttons.Count; i++)
            {
                buttonsDict.Add(buttons[i], i);
            }
            var buttonIndices = Buttons.Select(button => buttonsDict[button]).ToArray();

            return new SimplifiedWheel(buttonIndices, AccentColor, BgColor);
        }
    }
}
