using CommandWheelForms.Forms;
using CommandWheelOverlay.Controller;
using CommandWheelOverlay.View.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandWheelForms.Editors
{
    class WheelEditor<CreationT> : IWheelEditor where CreationT : class, IWheel, new()
    {
        public CreationT AddWheel(IWheelElements elements)
        {
            CreationT wheel = new CreationT();
            bool accepted =  EditWheel(wheel, elements);
            if (accepted)
            {
                elements.Wheels.Add(wheel);
                return wheel;
            }
            return null;
        }

        public bool EditWheel(IWheel wheel, IWheelElements elements)
        {
            WheelEditorForm form = new WheelEditorForm(wheel, elements);
            if (form.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        public bool RemoveWheel(IWheel wheel, IWheelElements elements)
        {
            Form dialog = new ComfirmationDialog($"Are you sure you wish to delete wheel '{wheel.Label}'?", "Comfirm deletion");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int index = elements.Wheels.IndexOf(wheel);
                elements.Wheels.Remove(wheel);
                if (index <= elements.StartupWheel)
                {
                    int newIndex = index - 1;
                    if (index < 0 && elements.Wheels.Count > 0)
                    {
                        newIndex = 1;
                    }
                    elements.StartupWheel = newIndex;
                }
                return true;
            }
            return false;
        }

        IWheel IWheelEditor.AddWheel(IWheelElements elements) => AddWheel(elements);
    }
}
