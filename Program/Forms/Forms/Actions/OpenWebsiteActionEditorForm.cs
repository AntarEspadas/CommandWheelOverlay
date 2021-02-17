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
    public partial class OpenWebsiteActionEditorForm : Form
    {
        public string Url => urlTextBox.Text;

        public OpenWebsiteActionEditorForm(OpenWebsiteAction action)
        {

            InitializeComponent();

            urlTextBox.Text = action.Url;
        }

        private void OpenWebsiteActionEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !Validate();
        }

        private void UrlTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex urlRegex = new Regex(@"^\s*(http(s)?:\/\/.)?(www\.)?[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)\s*$");
            if (urlRegex.IsMatch(urlTextBox.Text))
            {
                urlErrorLabel.Visible = false;
                return;
            }
            urlErrorLabel.Visible = true;
            e.Cancel = true;
        }
    }
}
