using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CommandWheelOverlay.View
{
    public interface ISimplifiedWheel
    {
        int[] ButtonIndices { get; set; }
        int[] AccentColor { get; set; }
        int[] BgColor { get; set; }
    }
}
