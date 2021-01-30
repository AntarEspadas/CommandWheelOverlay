using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandWheelOverlay.Connection;
using CommandWheelOverlay.Input;
using CommandWheelOverlay.View;
using Linearstar.Windows.RawInput;

namespace CommandWheelForms
{
    partial class MainWindow : Form
    {
        private TcpOverlayView view;
        public MainWindow()
        {
            InitializeComponent();
            view = new TcpOverlayView(null, 7777);
            while (true)
            {
                try
                {
                    view.Connect();
                    break;
                }
                catch (System.Net.Sockets.SocketException)
                {
                    continue;
                }
            }
            
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_INPUT = 0x00FF;
            if (m.Msg == WM_INPUT)
            {
                var data = RawInputData.FromHandle(m.LParam);
                if (data is RawInputMouseData mouseData)
                {
                    view.SendInput(new MouseInput(data.Device.ProductId, mouseData.Mouse.LastX, mouseData.Mouse.LastY, mouseData.Mouse.ButtonData, (MouseFlags)mouseData.Mouse.Flags, (MouseButton)mouseData.Mouse.Buttons));
                }
                else if (data is RawInputKeyboardData keyboardData)
                {
                    view.SendInput(new KeyboardInput(data.Device.ProductId, keyboardData.Keyboard.VirutalKey, keyboardData.Keyboard.ScanCode, (KeyboardFlags)keyboardData.Keyboard.Flags));
                }
            }

            base.WndProc(ref m);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var flags = RawInputDeviceFlags.InputSink;
            var handle = Handle;
            var registrations = new RawInputDeviceRegistration[]
            {
                    new RawInputDeviceRegistration(HidUsageAndPage.Keyboard, flags, handle),
                    new RawInputDeviceRegistration(HidUsageAndPage.Mouse, flags, handle)
            };
            RawInputDevice.RegisterDevice(registrations);
        }
        private void MainWindow_Shown(object sender, EventArgs e)
        {
            Hide();
        }
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            RawInputDevice.UnregisterDevice(HidUsageAndPage.Keyboard);
            RawInputDevice.UnregisterDevice(HidUsageAndPage.Mouse);
        }
    }
}
