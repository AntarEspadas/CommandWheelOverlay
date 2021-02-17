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
    public class OpenSteamAppActionEditor : ActionEditor<OpenSteamAppAction>
    {
        public override string DisplayName => "Open Steam game/app";

        public override OpenSteamAppAction CreateAction(IWheelElements elements)
        {
            var action = new OpenSteamAppAction();
            bool accepted = EditAction(action, elements);
            return accepted ? action : null;
        }

        public override bool EditAction(OpenSteamAppAction action, IWheelElements elements)
        {
            var form = new OpenSteamAppActionEditorForm(action);
            if (form.ShowDialog() == DialogResult.OK)
            {
                action.AppId = form.AppId;
                return true;
            }
            return false;
        }
    }
}
