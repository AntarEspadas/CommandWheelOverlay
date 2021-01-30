using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Input
{
    [Flags]
    public enum MouseFlags : ushort
    {
        MoveRelative = 0,
        MoveAbsolute = 1,
        VirtualDesktop = 2,
        AttributesChanged = 4,
    }
}
