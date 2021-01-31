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
            throw new NotImplementedException();
        }

        IWheel IWheelEditor.AddWheel(IWheelElements elements) => AddWheel(elements);
    }
}
