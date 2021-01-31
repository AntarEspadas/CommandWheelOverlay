using System;
using System.Collections.Generic;
using System.Text;
using CommandWheelOverlay.View;

namespace CommandWheelOverlay.Controller
{
    public interface IWheelAction : ICloneable
    {
        void Perform();

        SimplifiedWheelAction Simplify();
    }
}
