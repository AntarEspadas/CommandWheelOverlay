using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommandWheelForms.Editors;
using CommandWheelForms.Editors.Actions;
using CommandWheelOverlay.Connection;
using CommandWheelOverlay.Controller;
using CommandWheelOverlay.Controller.Actions;
using CommandWheelOverlay.Input;
using CommandWheelOverlay.View;
using CommandWheelOverlay.View.Editors;
using Linearstar.Windows.RawInput;

namespace CommandWheelForms.Forms
{
    partial class MainWindow : Form
    {
        private FormWindowState lastState;
        private bool closeForReal = false;
        private TcpOverlayView view;
        private OverlayController controller;
        public MainWindow()
        {
            IWheelElements elements = new WheelElements()
            {
                Editor = new ElementsEditor()
                {
                    WheelEditor = new WheelEditor<Wheel>(),
                    ButtonEditor = new ButtonEditor<WheelButton>(),
                    ActionEditors = new List<IActionEditor>() {new ShowSubwheelActionEditor() }
                }
            };
            controller = new OverlayController(elements, null);
            InitializeComponent();
            view = new TcpOverlayView(controller, 7777);
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
            controller.View = view;
            
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_INPUT = 0x00FF;
            if (m.Msg == WM_INPUT)
            {
                var data = RawInputData.FromHandle(m.LParam);
                try
                {
                    if (data is RawInputMouseData mouseData)
                    {
                        view.SendInput(new MouseInput(data.Device.ProductId, mouseData.Mouse.LastX, mouseData.Mouse.LastY, mouseData.Mouse.ButtonData, (MouseFlags)mouseData.Mouse.Flags, (MouseButton)mouseData.Mouse.Buttons));
                    }
                    else if (data is RawInputKeyboardData keyboardData)
                    {
                        view.SendInput(new KeyboardInput(data.Device.ProductId, keyboardData.Keyboard.VirutalKey, keyboardData.Keyboard.ScanCode, (KeyboardFlags)keyboardData.Keyboard.Flags));
                    }
                }
                catch (NullReferenceException) { }
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

            trayIcon.Visible = true;
        }
        private void MainWindow_Shown(object sender, EventArgs e)
        {
            Hide();
        }
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            RawInputDevice.UnregisterDevice(HidUsageAndPage.Keyboard);
            RawInputDevice.UnregisterDevice(HidUsageAndPage.Mouse);
            trayIcon.Visible = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            closeForReal = true;
            Application.Exit();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Show();
            Activate();
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            Activate();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !closeForReal;
            Hide();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                WindowState = lastState;
            }
            else
            {
                lastState = WindowState;
            }
        }

        private void editElementsButton_Click(object sender, EventArgs e)
        {
            controller.UpdateElements();
        }

        private void editSettingsButton_Click(object sender, EventArgs e)
        {
            controller.UpdateSettings();
        }
    }
}
