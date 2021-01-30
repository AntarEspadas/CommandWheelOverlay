using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Connection
{
    [Serializable]
    class Packet
    {
        public string TargetMehtod { get; }
        public object[] Parameters { get; }

        public Packet(string targetMehtod, object[] parameters)
        {
            TargetMehtod = targetMehtod;
            Parameters = parameters;
        }
    }
}
