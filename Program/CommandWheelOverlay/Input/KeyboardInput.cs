using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Input
{
    [Serializable]
    public class KeyboardInput
    {
        public int DeviceId { get; }
        public int Key { get; }
        public int ScanCode { get; }
        public KeyboardFlags Flags { get; }

        public KeyboardInput(int deviceId, int key, int scanCode, KeyboardFlags flags)
        {
            DeviceId = deviceId;
            Key = key;
            ScanCode = scanCode;
            Flags = flags;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Key: {1}, ScanCode: {2}, Flags: {3}", DeviceId, Key, ScanCode, Flags);
        }
    }
}
