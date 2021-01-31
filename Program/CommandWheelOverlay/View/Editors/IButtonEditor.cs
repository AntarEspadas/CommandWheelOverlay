using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View.Editors
{
    public interface IButtonEditor
    {
        IWheelButton AddButton(IWheelElements elements);
        bool EditButton(IWheelButton button, IWheelElements elements);
        bool RemoveButton(IWheelButton button, IWheelElements elements);
    }
}
