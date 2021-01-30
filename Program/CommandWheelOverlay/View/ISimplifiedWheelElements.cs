using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View
{
    public interface ISimplifiedWheelElements
    {
        ISimplifiedWheel[] Wheels { get; set; }
        ISimplifiedWheelButton[] Buttons { get; set; }
    }
}
