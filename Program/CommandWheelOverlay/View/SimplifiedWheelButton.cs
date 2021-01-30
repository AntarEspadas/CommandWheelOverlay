using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View
{
    public struct SimplifiedWheelButton
    {
        public string Label { get; }
        public string ImgPath { get; }
        public int SubWheelIndex { get; }
        public ISimplifiedWheelAction Action { get; }

        public SimplifiedWheelButton(string label, string imgPath, int subWheelIndex, ISimplifiedWheelAction action)
        {
            Label = label;
            ImgPath = imgPath;
            SubWheelIndex = subWheelIndex;
            Action = action;
        }
    }
}
