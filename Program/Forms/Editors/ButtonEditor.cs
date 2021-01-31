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
    class ButtonEditor<CreationT> : IButtonEditor where CreationT : class, IWheelButton, new()
    {
        public CreationT AddButton(IWheelElements elements)
        {
            CreationT newButton = new CreationT();
            bool accepted = EditButton(newButton, elements);
            if (accepted)
            {
                elements.Buttons.Add(newButton);
                return newButton;
            }
            return null;
        }

        public bool EditButton(IWheelButton button, IWheelElements elements)
        {
            ButtonEditorForm form = new ButtonEditorForm(button, elements);
            if (form.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        public bool RemoveButton(IWheelButton button, IWheelElements elements)
        {
            bool result = false;
            foreach (IWheel wheel in elements.Wheels)
            {
                result |= wheel.Buttons.Remove(button);
            }
            return result;
        }

        IWheelButton IButtonEditor.AddButton(IWheelElements elements) => AddButton(elements);
    }
}
