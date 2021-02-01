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

        public SimplifiedWheelButton(string label, string imgPath, SimplifiedWheelAction action)
        {
            Label = label;
            ImgPath = imgPath;
            Action = action;
        }
    }
}
