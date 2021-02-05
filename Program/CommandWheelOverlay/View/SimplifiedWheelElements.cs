using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandWheelOverlay.View
{
    [Serializable]
    public struct SimplifiedWheelElements
    {
        public SimplifiedWheel[] Wheels { get; }
        public SimplifiedWheelButton[] Buttons { get; }
        public int StartupWheel { get; }

        public SimplifiedWheelElements(IWheelElements elements)
        {
            Wheels = elements.Wheels.Select(wheel => new SimplifiedWheel(wheel, elements)).ToArray();
            Buttons = elements.Buttons.Select(button => new SimplifiedWheelButton(button, elements)).ToArray();
            StartupWheel = elements.StartupWheel;
        }
    }
}
