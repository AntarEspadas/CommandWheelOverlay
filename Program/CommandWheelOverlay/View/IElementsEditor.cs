using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View
{
    public interface IElementsEditor
    {
        IWheelElements Edit(IWheelElements wheelElementsCopy);
    }
}
