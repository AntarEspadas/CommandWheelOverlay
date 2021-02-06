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

        public ElementsEditorForm(IWheelElements elements)
        {
            InitializeComponent();
            this.elements = elements;
            UpdateWheelsList();
        }

        private void UpdateWheelsList()
        {
            wheelsLayoutPanel.SuspendDrawing();
            wheelsLayoutPanel.Controls.Clear();
            for (int i = 0; i < elements.Wheels.Count; i++)
            {
                var item = new ElementListItem(elements.Wheels[i]);
                item.label1.Text = elements.Wheels[i].Label;
                item.deleteButton.Click += DeleteWheel_Click;
                item.editButton.Click += EditWheel_Click;
                item.BackColor = Color.LightGray;
                item.UpClick += Item_UpClick;
                item.DownClick += Item_DownClick;
                wheelsLayoutPanel.Controls.Add(item);
                AdjustWidth(item);
            }
            wheelsLayoutPanel.ResumeDrawing();
        }

        private void Item_DownClick(object sender, EventArgs e)
        {
            IWheel movedWheel = (IWheel)((ElementListItem)sender).Element;
            if (elements.Wheels[elements.Wheels.Count - 1] == movedWheel) return;
            MoveElement(elements.Wheels, movedWheel, 1);
            UpdateWheelsList();
        }

        private void MoveElement<T>(IList<T> list, T element, int positions)
        {
            int index = list.IndexOf(element);
            list.RemoveAt(index);
            list.Insert(index + positions, element);
        }

        private void Item_UpClick(object sender, EventArgs e)
        {
            IWheel movedWheel = (IWheel)((ElementListItem)sender).Element;
            if (elements.Wheels[0] == movedWheel) return;
            MoveElement(elements.Wheels, movedWheel, -1);
            UpdateWheelsList();
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
                if (elements.StartupWheel is null) elements.StartupWheel = wheel;
                elements.Wheels.Add(wheel);
                UpdateWheelsList();
            }
        }
    }
}
