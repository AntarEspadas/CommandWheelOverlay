using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View
{
    public struct SimplifiedWheelElements
    {
        public SimplifiedWheel[] Wheels { get; }
        public SimplifiedWheelButton[] Buttons { get; }

        public SimplifiedWheelElements(SimplifiedWheel[] wheels, SimplifiedWheelButton[] buttons)
        {
            Wheels = wheels;
            Buttons = buttons;
        }
    }
}
