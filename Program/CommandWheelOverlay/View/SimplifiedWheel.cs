using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CommandWheelOverlay.View
{
    [Serializable]
    public struct SimplifiedWheel
    {
        public int[] ButtonIndices { get; }
        public int[] AccentColor { get; }
        public int[] BgColor { get; }
        public string Label { get; }

        public SimplifiedWheel(IWheel wheel, IWheelElements elements)
        {
            Dictionary<IWheelButton, int> allButtons = new Dictionary<IWheelButton, int>();
            for (int i = 0; i < elements.Buttons.Count; i++)
            {
                allButtons[elements.Buttons[i]] = i;
            }
            ButtonIndices = new int[elements.Buttons.Count];
            for (int i = 0; i < ButtonIndices.Length; i++)
            {
                ButtonIndices[i] = allButtons[wheel.Buttons[i]];
            }
            AccentColor = ToArray(wheel.AccentColor);
            BgColor = ToArray(wheel.BgColor);
            Label = wheel.Label;

            int[] ToArray(Color color)
            {
                return new int[] { color.R, color.G, color.B, color.A };
            }
        }

    }
}
