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
    class ButtonEditor<CreationT> : IButtonEditor where CreationT : class, IWheelButton, new()
    {
        public CreationT AddButton(IWheelElements elements)
        {
            CreationT newButton = new CreationT();
            bool accepted = EditButton(newButton, elements);
            return accepted ? newButton : null;
        }

        public bool EditButton(IWheelButton button, IWheelElements elements)
        {
            ButtonEditorForm form = new ButtonEditorForm(button, elements);
            if (form.ShowDialog() == DialogResult.OK)
            {
                button.Label = form.Label;
                button.ImgPath = form.ImgPath;
                button.Action = form.Action;
                return true;
            }
            return false;
        }

        public bool RemoveButton(IWheelButton button, IWheelElements elements)
        {
            var dialog = new ComfirmationDialog($"Are you sure you wish to delete button '{button.Label}'?", "Comfirmation");
            if (dialog.ShowDialog() != DialogResult.OK)
                return false;
            elements.Buttons.Remove(button);
            foreach (IWheel wheel in elements.Wheels)
            {
                wheel.Buttons.Remove(button);
            }
            return true;
        }

        IWheelButton IButtonEditor.AddButton(IWheelElements elements) => AddButton(elements);
    }
}
