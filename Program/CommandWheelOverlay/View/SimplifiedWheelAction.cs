using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.View
{
    [Serializable]
    public struct SimplifiedWheelAction
    {
        int Type { get; }

        public SimplifiedWheelAction(int type)
        {
            Type = type;
        }
    }
}
