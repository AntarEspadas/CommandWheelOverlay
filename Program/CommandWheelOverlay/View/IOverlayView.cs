using System;
using System.Collections.Generic;
using System.Text;
using CommandWheelOverlay.Input;
using CommandWheelOverlay.Settings;

namespace CommandWheelOverlay.View
{
    public interface IOverlayView
    {
        void UpdateElements(ISimplifiedWheelElements elements);
        void UpdateSettings(IUserSettings settings);
        void SendInput(KeyboardInput input);
        void SendInput(MouseInput input);
    }
}
