using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CommandWheelOverlay.View
{
    public struct SimplifiedWheel
    {
        public int[] ButtonIndices { get; }
        public int[] AccentColor { get; }
        public int[] BgColor { get; }

        public SimplifiedWheel(int[] buttonIndices, Color accentColor, Color bgColor)
        {
            ButtonIndices = buttonIndices;
            AccentColor = ToArray(accentColor);
            BgColor = ToArray(bgColor);

            int[] ToArray(Color color)
            {
                return new int[] { color.R, color.G, color.B, color.A };
            }
        }

    }
}
