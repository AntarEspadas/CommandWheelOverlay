using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Input
{
    [Serializable]
    public class MouseInput
    {
        public int DeviceId { get; }
        public int LastX { get; }
        public int LastY { get; }
        public int ButtonData { get; }
        public MouseFlags Flags { get; }
        public MouseButton Buttons { get; }

        public MouseInput(int deviceId, int lastX, int lastY, int buttonData, MouseFlags flags, MouseButton buttons)
        {
            DeviceId = deviceId;
            LastX = lastX;
            LastY = lastY;
            ButtonData = buttonData;
            Flags = flags;
            Buttons = buttons;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, LastX: {1}, LastY: {2}, ButtonData: {3}, Flags: {4}, Buttons: {5}", DeviceId, LastX, LastY, ButtonData, Flags, Buttons);
        }
    }
}
