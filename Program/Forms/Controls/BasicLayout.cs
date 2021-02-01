using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandWheelForms.Controls
{
    public partial class BasicLayout : UserControl
    {
        public event EventHandler ClickOkButton;
        public event EventHandler ClickCancelButton;

        public BasicLayout()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ClickOkButton?.Invoke(sender, e);
            ParentForm.DialogResult = DialogResult.OK;
            ParentForm.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClickCancelButton?.Invoke(sender, e);
            ParentForm.DialogResult = DialogResult.Cancel;
            ParentForm.Close();
        }
    }
}
