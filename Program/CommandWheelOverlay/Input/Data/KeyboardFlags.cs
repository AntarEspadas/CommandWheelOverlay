using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Input
{
    [Flags]
    public enum KeyboardFlags : ushort
    {
        Down = 0,
        Up = 1,
        LeftKey = 2,
        RightKey = 4,
    }
}
