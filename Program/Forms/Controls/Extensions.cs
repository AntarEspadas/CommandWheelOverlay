using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandWheelForms.Forms
{
    public static class Extensions
    {

        private const int WM_SETREDRAW = 11;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, bool wParam, int lParam);

        public static void SuspendDrawing(this Control control)
        {
            SendMessage(control.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(this Control control)
        {
            SendMessage(control.Handle, WM_SETREDRAW, true, 0);
            control.Refresh();
        }
    }
}
