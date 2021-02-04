using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Input
{
    [Serializable]
    public class KeyboardInput
    {
        public int Key { get; }
        public int ScanCode { get; }
        public KeyboardFlags Flags { get; }

        public KeyboardInput(int key, int scanCode, KeyboardFlags flags)
        {
            Key = key;
            ScanCode = scanCode;
            Flags = flags;
        }

        public override string ToString()
        {
            return $"Key: {Key}, ScanCode: {ScanCode}, Flags: {Flags}";
        }
    }
}
