using System;
using System.Collections.Generic;
using CommandWheelOverlay.View;
using CommandWheelOverlay.View.Editors;

namespace CommandWheelOverlay.Controller
{
    public interface IWheelElements : ICloneable
    {
        IElementsEditor Editor { get; set; }
        IList<IWheel> Wheels { get; set; }
        IList<IWheelButton> Buttons { get; set; }
        int StartupWheel { get; set; }

    }
}
