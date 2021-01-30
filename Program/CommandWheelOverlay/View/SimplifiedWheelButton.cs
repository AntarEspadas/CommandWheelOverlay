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
        public int SubWheelIndex { get; }
        public SimplifiedWheelAction Action { get; }

        public SimplifiedWheelButton(string label, string imgPath, int subWheelIndex, SimplifiedWheelAction action)
        {
            Label = label;
            ImgPath = imgPath;
            SubWheelIndex = subWheelIndex;
            Action = action;
        }
    }
}
