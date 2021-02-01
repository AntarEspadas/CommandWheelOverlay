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

namespace CommandWheelForms.Forms
{
    public partial class WheelEditorForm : Form
    {
        private IWheel wheel;
        private IWheelElements elements;
        public WheelEditorForm(IWheel wheel, IWheelElements elements)
        {
            InitializeComponent();
            this.wheel = wheel;
            this.elements = elements;
        }
    }
}
