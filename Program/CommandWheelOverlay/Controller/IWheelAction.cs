using System;
using System.Collections.Generic;
using System.Text;
using CommandWheelOverlay.View;

namespace CommandWheelOverlay.Controller
{
    public interface IWheelAction : ICloneable
    {
        IWheel SubWheel { get; set; }

        void Perform();

        SimplifiedWheelAction Simplify(IList<IWheel> wheels);
    }
}
