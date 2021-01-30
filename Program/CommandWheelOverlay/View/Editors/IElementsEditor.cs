using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View.Editors
{
    public interface IElementsEditor
    {
        IWheelEditor WheelEditor { get; set; }
        IButtonEditor ButtonEditor { get; set; }
        IList<IActionEditor> ActionEditors { get; set; }
        IWheelElements Edit(IWheelElements wheelElementsCopy);
    }
}
