using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View.Editors
{
    public interface IWheelEditor
    {
        IWheel CreateWheel();
        IWheel EditWheel(IWheel wheel);
    }
}
