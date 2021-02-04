using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Input
{
    interface IInputHandler
    {
        void Handle(MouseInput input);
        void Handle(KeyboardInput input);
    }
}
