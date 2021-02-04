using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Input
{
    [Serializable]
    public class MouseInput
    {
        public int LastX { get; }
        public int LastY { get; }
        public int ButtonData { get; }
        public MouseFlags Flags { get; }
        public MouseButton Buttons { get; }

        public MouseInput(int lastX, int lastY, int buttonData, MouseFlags flags, MouseButton buttons)
        {
            LastX = lastX;
            LastY = lastY;
            ButtonData = buttonData;
            Flags = flags;
            Buttons = buttons;
        }

        public override string ToString()
        {
            return $"LastX: {LastX}, LastY: {LastY}, ButtonData: {ButtonData}, Flags: {Flags}, Buttons: {Buttons}";
        }
    }
}
