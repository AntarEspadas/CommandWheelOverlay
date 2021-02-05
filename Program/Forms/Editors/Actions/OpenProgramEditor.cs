using CommandWheelForms.Forms.Actions;
using CommandWheelOverlay.Controller;
using CommandWheelOverlay.Controller.Actions;
using CommandWheelOverlay.View.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandWheelForms.Editors.Actions
{
    class OpenProgramEditor : ActionEditor<OpenProgramAction>
    {
        public override string DisplayName => "Open program";

        public override OpenProgramAction CreateAction(IWheelElements elements)
        {
            var action = new OpenProgramAction();
            bool accepted = EditAction(action, elements);
            return accepted ? action : null;
        }

        public override bool EditAction(OpenProgramAction action, IWheelElements elements)
        {
            OpenProgramActionEditorForm form = new OpenProgramActionEditorForm(action);
            if (form.ShowDialog() == DialogResult.OK)
            {
                action.ProgramPath = form.ProgramPath;
                action.Arguments = form.Arguments;
                return true;
            }
            return false;
        }
    }
}
