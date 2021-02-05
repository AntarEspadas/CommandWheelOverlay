using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View
{
    [Serializable]
    public struct SimplifiedWheelButton
    {
        public string Label { get; }
        public string ImgPath { get; }
        public SimplifiedWheelAction? Action { get; }

        public SimplifiedWheelButton(IWheelButton button, IWheelElements elements)
        {
            Label = button.Label;
            ImgPath = button.ImgPath;
            if (button.Action != null)
            {
                Action = new SimplifiedWheelAction(button.Action, elements);
            }
            else
            {
                Action = null;
            }
        }
    }
}
