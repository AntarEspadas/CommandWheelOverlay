using CommandWheelOverlay.Input;
using CommandWheelOverlay.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandWheelForms.Forms
{
    public partial class SettingsEditorForm : Form
    {
        private IInputHandler inputHandler;

        public IList<int> ShowHotkey { get; private set; }
        public IList<int> MoveLeftHotkey { get; private set; }
        public IList<int> MoveRightHotkey { get; private set; }

        public SettingsEditorForm(IUserSettings userSettings, IInputHandler inputHandler)
        {
            InitializeComponent();

            this.inputHandler = inputHandler;

            ShowHotkey = userSettings.ShowHotkey;
            MoveLeftHotkey = userSettings.MoveLeftHotkey;
            MoveRightHotkey = userSettings.MoveRightHotkey;
        }
    }
}
