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
    public class OpenWebsiteActionEditor : ActionEditor<OpenWebsiteAction>
    {
        public override string DisplayName => "Open Website";

        public override OpenWebsiteAction CreateAction(IWheelElements elements)
        {
            var action = new OpenWebsiteAction();
            bool accepted = EditAction(action, elements);
            return accepted ? action : null;
        }

        public override bool EditAction(OpenWebsiteAction action, IWheelElements elements)
        {
            var form = new OpenWebsiteActionEditorForm(action);
            if (form.ShowDialog() == DialogResult.OK)
            {
                action.Url = form.Url;
                return true;
            }
            return false;
        }
    }
}
