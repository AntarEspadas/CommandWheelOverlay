using CommandWheelOverlay.AdditionalActions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CommandWheelForms.Forms.Actions
{
    public partial class HotkeyActionEditorForm : Form
    {

        public string[] Keys => hotkeyTextBox.Text.Split(' ');

        public HotkeyActionEditorForm(HotkeyAction action)
        {
            InitializeComponent();

            if (action.Keys != null)
                hotkeyTextBox.Text = string.Join(" ", action.Keys);
        }

        private void HotkeyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                hotkeyLinkLabel.LinkVisited = true;
                Process.Start("https://www.autohotkey.com/docs/KeyList.htm");
            }
            catch { }
        }
    }
}
