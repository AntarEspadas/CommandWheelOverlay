using System;
using System.Collections.Generic;
using System.Text;
using CommandWheelOverlay.View;

namespace CommandWheelOverlay.Controller
{
    public interface IWheelAction
    {
        void Perform();
        IWheelAction Clone(IWheelElements elements);
    }
}
