using CommandWheelForms.Controlls;
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
            wheelsLayoutPanel.Controls.Clear();
            for (int i = 0; i < elements.Wheels.Count; i++)
            {
                var item = new ElementListItem(elements.Wheels[i]);
                item.label1.Text = $"Wheel {i + 1}";
                item.deleteButton.Click += DeleteWheel_Click;
                item.editButton.Click += EditWheel_Click;
                item.BackColor = Color.LightGray;
                wheelsLayoutPanel.Controls.Add(item);
                AdjustWidth(item);
            }
        }

        private void UpdateButtonsList()
        {
            buttonsLayoutPanel.Controls.Clear();
            for (int i = 0; i < elements.Buttons.Count; i++)
            {
                var item = new ElementListItem(elements.Buttons[i]);
                item.label1.Text = elements.Buttons[i].Label;
                item.deleteButton.Click += DeleteButton_Click;
                item.editButton.Click += EditButton_Click;
                item.BackColor = Color.LightGray;
                buttonsLayoutPanel.Controls.Add(item);
                AdjustWidth(item);
            }
        }

        private void ActOnElement<T>(object child, Func<T, IWheelElements, bool> action)
        {
            ElementListItem item = (ElementListItem)((Button)child).Parent.Parent;
            bool reload = action((T)item.Element, elements);
            if (reload)
            {
                UpdateWheelsList();
                UpdateButtonsList();
            }
        }

        private void EditWheel_Click(object sender, EventArgs e)
        {
            ActOnElement<IWheel>(sender, elements.Editor.WheelEditor.EditWheel);
        }

        private void DeleteWheel_Click(object sender, EventArgs e)
        {
            ActOnElement<IWheel>(sender, elements.Editor.WheelEditor.RemoveWheel);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ActOnElement<IWheelButton>(sender, elements.Editor.ButtonEditor.EditButton);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ActOnElement<IWheelButton>(sender, elements.Editor.ButtonEditor.RemoveButton);
        }

        private void ElementsEditorForm_Resize(object sender, EventArgs e)
        {
            foreach (Control control in wheelsLayoutPanel.Controls)
            {
                AdjustWidth(control);
            }
            foreach (Control control in buttonsLayoutPanel.Controls)
            {
                AdjustWidth(control);
            }
        }

        private void AdjustWidth(Control control)
        {
            Control parent = control.Parent;
            control.Width = parent.Width - control.Margin.Left - control.Margin.Right;
        }

        private void AddWheelClick(object sender, EventArgs e)
        {
            var wheel = elements.Editor.WheelEditor.AddWheel(elements);
            if (wheel != null)
            {
                UpdateWheelsList();
                UpdateButtonsList();
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            var button = elements.Editor.ButtonEditor.AddButton(elements);
            if (button != null)
            {
                UpdateWheelsList();
                UpdateButtonsList();
            }
        }
    }
}
