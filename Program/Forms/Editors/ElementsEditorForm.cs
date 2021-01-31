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
using static System.Windows.Forms.ListView;

namespace CommandWheelForms.Editors
{
    public partial class ElementsEditorForm : Form
    {
        private IList<IWheel> wheels;
        private IList<IWheelButton> buttons;
        public ElementsEditorForm() : this(new List<IWheel>(), new List<IWheelButton>())
        {
        }

        public ElementsEditorForm(IList<IWheel> wheels, IList<IWheelButton> buttons)
        {
            InitializeComponent();
            this.wheels = wheels;
            this.buttons = buttons;
        }

        private void UpdateButtonsList()
        {
            wheelsListView.Items.Clear();
            for (int i = 0; i < wheels.Count; i++)
            {
                wheelsListView.Items.Add($"Wheel {i + 1}");
            }
        }

        private void UpdateWheelsList()
        {
            buttonsListView.Items.Clear();
            for (int i = 0; i < buttons.Count; i++)
            {
                buttonsListView.Items.Add($"Button {i + 1}");
            }
        }
    }
}
