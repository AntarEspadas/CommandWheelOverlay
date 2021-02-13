using CommandWheelOverlay.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandWheelForms.Input
{
    class KeyNameConverter
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetKeyboardLayout(uint idThread);

        [DllImport("user32.dll")]
        private static extern uint MapVirtualKeyEx(uint uCode, uint uMapType, IntPtr dwhkl);

        [DllImport("user32.dll")]
        private static extern int GetKeyNameText(uint lParam, [Out] StringBuilder lpString, int nSize);

        private readonly IntPtr _dwhkl;
        private const int size = 260;

        public KeyNameConverter()
        {
            _dwhkl = GetKeyboardLayout(0);
        }

        public string GetName(int keyCode)
        {
            if (keyCode < 0)
            {
                keyCode *= -1;
                MouseButton button = (MouseButton)keyCode;
                string result = button.ToString();
                return result.Substring(0, result.Length - 4);
            }
            uint scanCode = MapVirtualKeyEx((uint)keyCode, 0, _dwhkl) << 16;
            if (scanCode == 0) return "UNKNOWN";
            StringBuilder builder = new StringBuilder(size);
            int success = GetKeyNameText(scanCode, builder, 100);
            if (success == 0) return "UNKNWON";
            return builder.ToString();
        }
    }
}
