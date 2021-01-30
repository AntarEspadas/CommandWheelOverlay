using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Input
{
    [Flags]
    public enum MouseButton : ushort
    {
        None,
        LeftButtonDown = 0x0001,
        LeftButtonUp = 0x0002,
        RightButtonDown = 0x0004,
        RightButtonUp = 0x0008,
        MiddleButtonDown = 0x0010,
        MiddleButtonUp = 0x0020,
        Button4Down = 0x0040,
        Button4Up = 0x0080,
        Button5Down = 0x0100,
        Button5Up = 0x0200,
        MouseWheel = 0x0400,
        MouseHorizontalWheel = 0x0800,
    }
}
