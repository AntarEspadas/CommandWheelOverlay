using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View.Editors
{
    public interface IButtonEditor
    {
        IWheelButton AddButton(IWheelElements elements);
        void EditButton(IWheelButton button, IWheelElements elements);
        void RemoveButton(IWheelButton button, IWheelElements elements);
    }
}
