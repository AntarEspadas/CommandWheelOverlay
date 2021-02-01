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
        private bool comboBoxChangedByUser = true;
        public IWheel SubWheel { get; private set; }
        public ShowSubwheelActionEditorForm(ShowSubwheelAction action, IWheelElements elements)
        {
            InitializeComponent();
            this.action = action;
            this.elements = elements;

            SubWheel = action.SubWheel;

            subWheelEditButton.Enabled = false;
            UpdateComboBox();
        }

        private void UpdateComboBox()
        {
            comboBoxChangedByUser = false;
            subWheelComboBox.Items.Clear();
            subWheelComboBox.Items.Add("None");
            comboBoxChangedByUser = false;
            subWheelComboBox.SelectedIndex = 0;
            var wheels = elements.Wheels;
            for (int i = 0; i < wheels.Count; i++)
            {
                subWheelComboBox.Items.Add(wheels[i].Label);
                if (wheels[i] == SubWheel)
                {
                    comboBoxChangedByUser = false;
                    subWheelEditButton.Enabled = true;
                    subWheelComboBox.SelectedIndex = i + 1;
                }
            }
            subWheelComboBox.Items.Add("Add");
        }

        private void subWheelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBoxChangedByUser)
            {
                comboBoxChangedByUser = true;
            }
            else if (subWheelComboBox.SelectedIndex == 0)
            {
                subWheelEditButton.Enabled = false;
                SubWheel = null;
            }
            else if (subWheelComboBox.SelectedIndex == subWheelComboBox.Items.Count - 1)
            {
                SubWheel = elements.Editor.WheelEditor.AddWheel(elements) ?? SubWheel;
                UpdateComboBox();
            }
            else
            {
                SubWheel = elements.Wheels[subWheelComboBox.SelectedIndex - 1];
                subWheelEditButton.Enabled = true;
            }
        }

        private void subWheelEditButton_Click(object sender, EventArgs e)
        {
            elements.Editor.WheelEditor.EditWheel(elements.Wheels[subWheelComboBox.SelectedIndex - 1], elements);
        }
    }
}
