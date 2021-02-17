using CommandWheelOverlay.Controller.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandWheelForms.Forms.Actions
{
    public partial class OpenSteamAppActionEditorForm : Form
    {
        public int AppId => int.Parse(idTextBox.Text);

        public OpenSteamAppActionEditorForm(OpenSteamAppAction action)
        {
            InitializeComponent();

            idTextBox.Text = action.AppId.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"((?![0-9]).)*");
            idTextBox.Text = regex.Replace(idTextBox.Text, "");
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
