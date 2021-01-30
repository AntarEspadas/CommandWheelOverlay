using System;
using System.Collections.Generic;
using CommandWheelOverlay.View;

namespace CommandWheelOverlay.Controller
{
    public interface IWheelElements : ICloneable
    {
        IList<IWheel> Wheels { get; set; }
        IList<IWheelButton> Buttons { get; set; }

        ISimplifiedWheelElements Simplify();
    }
}
