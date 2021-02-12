using System;
using System.Collections.Generic;
using System.Text;
using CommandWheelOverlay.Input;
using CommandWheelOverlay.Settings;

namespace CommandWheelOverlay.View
{
    public interface IOverlayView
    {
        void UpdateElements(SimplifiedWheelElements elements);
        void SendMouseMovement(int[] deltas);
        void MoveLeft();
        void MoveRight();
        void Show();
        void Hide();
    }
}
