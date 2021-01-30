using System;
using System.Linq;
using System.Windows.Forms;
using Linearstar.Windows.RawInput;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using CommandWheelOverlay.Connection;
using CommandWheelOverlay.Input;

namespace CommandWheelForms
{
    public class Program
    {
        private static string pipeName = "CommandWheelOverlayNamedPipe";
        public static void Main(string[] args)
        {
            if (args.Length > 0 && !string.IsNullOrWhiteSpace(args[0]))
                pipeName = args[0];

            Form1 form = new Form1();

            TcpOverlayView view = new TcpOverlayView(null, 7777);
            view.Connect();

            var window = new RawInputReceiverWindow();
            form.OnInputRecieved += (sender, e) =>
            {
                // Catch your input here!
                var data = e.Data;
                if (data is RawInputMouseData mouseData)
                {
                    view.SendInput(new MouseInput(data.Device.ProductId, mouseData.Mouse.LastX, mouseData.Mouse.LastY, mouseData.Mouse.ButtonData, (MouseFlags)mouseData.Mouse.Flags, (MouseButton)mouseData.Mouse.Buttons ));
                }
                else if (data is RawInputKeyboardData keyboardData)
                {
                    view.SendInput(new KeyboardInput(data.Device.ProductId, keyboardData.Keyboard.VirutalKey, keyboardData.Keyboard.ScanCode, (KeyboardFlags)keyboardData.Keyboard.Flags));
                }
            };
            try
            {
                var flags = RawInputDeviceFlags.InputSink;
                var handle = form.Handle;
                var registrations = new RawInputDeviceRegistration[]
                {
                    new RawInputDeviceRegistration(HidUsageAndPage.Keyboard, flags, handle),
                    new RawInputDeviceRegistration(HidUsageAndPage.Mouse, flags, handle)
                };
                RawInputDevice.RegisterDevice(registrations);
                Application.Run(form);
            }
            finally
            {
                RawInputDevice.UnregisterDevice(HidUsageAndPage.Keyboard);
                RawInputDevice.UnregisterDevice(HidUsageAndPage.Mouse);
            }
        }
    }
}