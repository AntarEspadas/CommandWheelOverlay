using CommandWheelForms.Controlls;
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
        public Color BgColor => bgColorPanel.BackColor;
        public Color AccentColor => accentColorPanel.BackColor;
        public string Label => nameTextBox.Text;
        public List<IWheelButton> Buttons { get; private set; }
        public WheelEditorForm(IWheel wheel, IWheelElements elements)
        {
            InitializeComponent();
            this.wheel = wheel;
            this.elements = elements;

            bgColorPanel.BackColor = wheel.BgColor;
            accentColorPanel.BackColor = wheel.AccentColor;
            nameTextBox.Text = wheel.Label;

            if (wheel.Buttons != null)
            {
                Buttons = new List<IWheelButton>(wheel.Buttons);
            }
            else
            {
                Buttons = new List<IWheelButton>();
            }
            UpdateButtonList();
        }

        private void UpdateButtonList()
        {
            buttonsLayoutPanel.SuspendDrawing();

            buttonsLayoutPanel.Controls.Clear();

            foreach (IWheelButton button in Buttons)
            {
                var control = new ElementListItem(button);
                control.label1.Text = button.Label;
                control.deleteButton.Click += DeleteButton_Click;
                control.editButton.Click += EditButton_Click;

                buttonsLayoutPanel.Controls.Add(control);

                control.Width = control.Parent.Width - 20;
            }

            buttonsLayoutPanel.ResumeDrawing();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ElementListItem listItem = (ElementListItem)((Control)sender).Parent.Parent;
            bool accepted = elements.Editor.ButtonEditor.EditButton((IWheelButton)listItem.Element, elements);
            if (accepted)
            {
                UpdateButtonList();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ElementListItem listItem = (ElementListItem)((Control)sender).Parent.Parent;
            IWheelButton button = (IWheelButton)listItem.Element;
            var dialog = new ComfirmationDialog($"Are you sure you wish to delete button '{button.Label}'?");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Buttons.Remove(button);
                UpdateButtonList();
            }
        }

        private void PickColor(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            colorPicker.Color = panel.BackColor;
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                panel.BackColor = colorPicker.Color;
            }
        }

        private void addButtonButton_Click(object sender, EventArgs e)
        {
            var button = elements.Editor.ButtonEditor.AddButton(elements);
            if (button != null)
            {
                Buttons.Add(button);
                UpdateButtonList();
            }
        }
    }
}
