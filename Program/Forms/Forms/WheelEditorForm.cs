using CommandWheelForms.Controlls;
using CommandWheelForms.Extensions;
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
        public bool IsStartup => startupWheelCheckbox.Checked;
        public List<IWheelButton> Buttons { get; private set; }
        public WheelEditorForm(IWheel wheel, IWheelElements elements)
        {
            InitializeComponent();
            this.wheel = wheel;
            this.elements = elements;

            bgColorPanel.BackColor = wheel.BgColor;
            bgColorAlphaNumericUpDown.Value = wheel.BgColor.A / 255M * 100;
            accentColorPanel.BackColor = wheel.AccentColor;
            nameTextBox.Text = wheel.Label;
            startupWheelCheckbox.Checked = wheel == elements.StartupWheel;

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
                control.UpClick += Control_UpClick;
                control.DownClick += Control_DownClick;

                buttonsLayoutPanel.Controls.Add(control);

                control.Width = control.Parent.Width - 20;
            }

            buttonsLayoutPanel.ResumeDrawing();
        }

        private void Control_DownClick(object sender, EventArgs e)
        {
            IWheelButton movedButton = (IWheelButton)((ElementListItem)sender).Element;
            if (Buttons[Buttons.Count - 1] == movedButton) return;
            Buttons.MoveElement(movedButton, 1);
            UpdateButtonList();
        }

        private void Control_UpClick(object sender, EventArgs e)
        {
            IWheelButton movedButton = (IWheelButton)((ElementListItem)sender).Element;
            if (Buttons[0] == movedButton) return;
            Buttons.MoveElement(movedButton, -1);
            UpdateButtonList();
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

        private void BgColorPanel_Click(object sender, EventArgs e)
        {
            PickColor((Panel)sender);
            ApplyAlpha();
        }

        private void AccentColorPanel_Click(object sender, EventArgs e)
        {
            PickColor((Panel)sender);
        }

        private void PickColor(Panel panel)
        {
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

        private void BgColorAlphaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ApplyAlpha();
        }

        private void ApplyAlpha()
        {
            var color = bgColorPanel.BackColor;
            int alpha = (int)(bgColorAlphaNumericUpDown.Value / 100 * 255);
            bgColorPanel.BackColor = Color.FromArgb(alpha, color);
        }
    }
}
