using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View.Editors
{
    public interface IButtonEditor
    {
        IWheelButton CreateButton();
        IWheelButton EditButton(IWheelButton button);
    }
}
