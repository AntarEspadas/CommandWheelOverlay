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

namespace CommandWheelForms.Forms
{
    public partial class ElementsEditorForm : Form
    {
        private IWheelElements elements;

        public int StartupWheel { get; private set; }

        public ElementsEditorForm(IWheelElements elements)
        {
            InitializeComponent();
            this.elements = elements;
            StartupWheel = elements.StartupWheel;
            UpdateWheelsList();
        }

        private void UpdateWheelsList()
        {
            wheelsLayoutPanel.Controls.Clear();
            for (int i = 0; i < elements.Wheels.Count; i++)
            {
                var item = new ElementListItem(elements.Wheels[i]);
                item.label1.Text = elements.Wheels[i].Label;
                item.deleteButton.Click += DeleteWheel_Click;
                item.editButton.Click += EditWheel_Click;
                item.BackColor = Color.LightGray;
                wheelsLayoutPanel.Controls.Add(item);
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

        private void ElementsEditorForm_Resize(object sender, EventArgs e)
        {
            foreach (Control control in wheelsLayoutPanel.Controls)
            {
                AdjustWidth(control);
            }
        }

        private void AdjustWidth(Control control)
        {
            Control parent = control.Parent;
            control.Width = parent.Width - control.Margin.Left - control.Margin.Right - parent.Padding.Right - parent.Padding.Left;
        }

        private void AddWheelClick(object sender, EventArgs e)
        {
            var wheel = elements.Editor.WheelEditor.AddWheel(elements);
            if (wheel != null)
            {
                elements.Wheels.Add(wheel);
                UpdateWheelsList();
            }
        }
    }
}
