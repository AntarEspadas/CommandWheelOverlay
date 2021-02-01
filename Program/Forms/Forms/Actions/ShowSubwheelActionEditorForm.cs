using CommandWheelOverlay.Controller;
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
    public partial class ShowSubwheelActionEditorForm : Form
    {
        private ShowSubwheelAction action;
        private IWheelElements elements;
        public ShowSubwheelActionEditorForm(ShowSubwheelAction action, IWheelElements elements)
        {
            InitializeComponent();
            this.action = action;
            this.elements = elements;
        }
    }
}
