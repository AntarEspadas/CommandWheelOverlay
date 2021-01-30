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

        public SimplifiedWheel(int[] buttonIndices, int[] accentColor, int[] bgColor)
        {
            ButtonIndices = buttonIndices;
            AccentColor = accentColor;
            BgColor = bgColor;
        }
    }
}
