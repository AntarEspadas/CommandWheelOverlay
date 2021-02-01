using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View
{
    [Serializable]
    public struct SimplifiedWheelAction
    {
        WheelActionType Type { get; }

        public SimplifiedWheelAction(WheelActionType type)
        {
            Type = type;
        }
    }
}
