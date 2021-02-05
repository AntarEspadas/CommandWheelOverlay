using CommandWheelOverlay.Controller.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandWheelForms.Forms.Actions
{
    public partial class OpenProgramActionEditorForm : Form
    {
        public string ProgramPath => pathTextBox.Text;
        public string Arguments => argsTextBox.Text;

        public OpenProgramActionEditorForm(OpenProgramAction action)
        {
            InitializeComponent();

            pathTextBox.Text = action.ProgramPath;
            argsTextBox.Text = action.Arguments;
        }
    }
}
