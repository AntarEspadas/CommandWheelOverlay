using CommandWheelOverlay.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandWheelForms.Editors
{
    public partial class ButtonEditorForm : Form
    {
        private IWheelButton button;
        private IWheelElements elements;

        public ButtonEditorForm(IWheelButton button, IWheelElements elements)
        {
            InitializeComponent();
            this.button = button;
            this.elements = elements;
        }

        private void ButtonEditorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
