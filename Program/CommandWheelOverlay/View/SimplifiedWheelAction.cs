using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View
{
    [Serializable]
    public struct SimplifiedWheelAction
    {
        public int SubWheelIndex { get; }
        public WheelActionType Type { get; }

        public SimplifiedWheelAction(WheelActionType type, int subWheelIndex)
        {
            Type = type;
            SubWheelIndex = subWheelIndex;
        }
    }
}
