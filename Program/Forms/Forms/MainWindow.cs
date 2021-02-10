using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommandWheelForms.Editors;
using CommandWheelForms.Editors.Actions;
using CommandWheelForms.Model;
using CommandWheelOverlay.Connection;
using CommandWheelOverlay.Controller;
using CommandWheelOverlay.Controller.Actions;
using CommandWheelOverlay.Input;
using CommandWheelOverlay.View;
using CommandWheelOverlay.View.Editors;
using JobManagement;
using Linearstar.Windows.RawInput;
using Linearstar.Windows.RawInput.Native;

namespace CommandWheelForms.Forms
{
    partial class MainWindow : Form
    {
        private FormWindowState lastState;
        private bool closeForReal = false;
        private TcpOverlayView view;
        private OverlayController controller;
        private IInputHandler inputHandler;

#if DEBUG
        private readonly string overlayPath = System.IO.Path.Combine(Program.programPath, "..", "..", "..", "..", "Overlay", "Build", "CommandWheelOverlay.exe");
#else
        private readonly string overlayPath = "";
#endif



        public MainWindow()
        {
            var model = new OverlayModel { ElementsPath = System.IO.Path.Combine(Program.programPath, "Elements.json") };

            IWheelElements elements = model.GetElements();
            elements = elements ?? new WheelElements();
            elements.Editor = new ElementsEditor()
            {
                WheelEditor = new WheelEditor<Wheel>(),
                ButtonEditor = new ButtonEditor<WheelButton>(),
                ActionEditors = new List<IActionEditor>() { new ShowSubwheelActionEditor(), new OpenProgramEditor() },
            };



            controller = new OverlayController(elements, null)
            {
                Model = model
            };
            InitializeComponent();
            view = new TcpOverlayView(controller, 7777);

            inputHandler = new InputHandler { View = view};
            inputHandler.ShowHotkey = new[] { 18 };

            Job job = new Job();
            Process process = new Process();
            process.StartInfo.FileName = overlayPath;
            process.Start();
            job.AddProcess(process.Handle);

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
            view.UpdateElements(new SimplifiedWheelElements(controller.Elements));
            
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_INPUT = 0x00FF;
            if (m.Msg == WM_INPUT)
            {
                var data = RawInputData.FromHandle(m.LParam);
                if (data is RawInputMouseData mouseData)
                {
                    var mouse = mouseData.Mouse;
                    inputHandler.Handle(new MouseInput(mouse.LastX, mouse.LastY, mouse.ButtonData, (MouseFlags)mouse.Flags, (MouseButton)mouse.Buttons));
                }
                else if (data is RawInputKeyboardData keyboardData)
                {
                    var keyboard = keyboardData.Keyboard;
                    inputHandler.Handle(new KeyboardInput(keyboard.VirutalKey, keyboard.ScanCode, (KeyboardFlags)keyboard.Flags));
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
