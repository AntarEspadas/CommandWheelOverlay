using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay
{

    [Serializable]
    public class OverlayException : Exception
    {
        public OverlayException() { }
        public OverlayException(string message) : base(message) { }
        public OverlayException(string message, Exception inner) : base(message, inner) { }
        protected OverlayException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
