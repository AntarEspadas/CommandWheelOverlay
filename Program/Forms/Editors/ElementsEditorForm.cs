using CommandWheelOverlay.Controller;
using CommandWheelOverlay.View.Editors;
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
        private IWheelElements elements;

        public ElementsEditorForm(IWheelElements elements)
        {
            InitializeComponent();
            this.elements = elements;
            UpdateButtonsList();
            UpdateWheelsList();
        }

        private void UpdateWheelsList()
        {
            //wheelsListView.Items.Clear();
            //for (int i = 0; i < elements.Wheels.Count; i++)
            //{
            //    wheelsListView.Items.Add($"Wheel {i + 1}");
            //}
        }

        private void UpdateButtonsList()
        {
            //buttonsListView.Items.Clear();
            //for (int i = 0; i < elements.Buttons.Count; i++)
            //{
            //    buttonsListView.Items.Add($"Button {i + 1}");
            //}
        }

        private void AddWheelClick(object sender, EventArgs e)
        {
            elements.Editor.WheelEditor.AddWheel(elements);
            UpdateWheelsList();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            elements.Editor.ButtonEditor.AddButton(elements);
            UpdateButtonsList();
        }
    }
}
