using CommandWheelOverlay.View;
using CommandWheelOverlay.View.Editors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandWheelOverlay.Controller
{
    public class WheelElements : IWheelElements
    {
        [JsonIgnore]
        public IElementsEditor Editor { get; set; }
        public IList<IWheel> Wheels { get; set; } = new List<IWheel>();
        public IList<IWheelButton> Buttons { get; set; } = new List<IWheelButton>();
        public IWheel StartupWheel { get; set; }

        public object Clone()
        {
            WheelElements clone = new WheelElements
            {
                Editor = Editor
            };
            clone.Wheels = Wheels.Select(wheel => wheel.Clone(clone)).ToList();
            clone.StartupWheel = StartupWheel is null ? null : clone.Wheels[Wheels.IndexOf(StartupWheel)];
            return clone;
        }
    }
}
