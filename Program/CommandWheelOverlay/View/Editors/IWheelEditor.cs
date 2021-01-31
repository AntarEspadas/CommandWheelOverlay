using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View.Editors
{
    public interface IWheelEditor
    {
        IWheel AddWheel(IWheelElements elements);
        bool EditWheel(IWheel wheel, IWheelElements elements);
        bool RemoveWheel(IWheel wheel, IWheelElements elements);
    }
}
