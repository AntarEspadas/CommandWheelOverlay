using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Connection
{

    [Serializable]
    public class ConnectionClosedException : OverlayException
    {
        public ConnectionClosedException() { }
        public ConnectionClosedException(string message) : base(message) { }
        public ConnectionClosedException(string message, Exception inner) : base(message, inner) { }
        protected ConnectionClosedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
