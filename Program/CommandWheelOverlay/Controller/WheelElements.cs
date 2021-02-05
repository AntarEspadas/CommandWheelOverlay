using CommandWheelOverlay.View;
using CommandWheelOverlay.View.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandWheelOverlay.Controller
{
    public class WheelElements : IWheelElements
    {
        public IElementsEditor Editor { get; set; }
        public IList<IWheel> Wheels { get; set; } = new List<IWheel>();
        public IList<IWheelButton> Buttons { get; set; } = new List<IWheelButton>();
        public int StartupWheel { get; set; }

        public object Clone()
        {
            WheelElements clone = new WheelElements
            {
                Editor = Editor,
                StartupWheel = StartupWheel
            };
            clone.Wheels = Wheels.Select(wheel => wheel.Clone(clone)).ToList();
            return clone;
        }
    }
}
