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
    class ShowSubwheelActionEditor : ActionEditor<ShowSubwheelAction>
    {
        public override string DisplayName => "Show Subwheel";

        public override ShowSubwheelAction CreateAction(IWheelElements elements)
        {
            var action = new ShowSubwheelAction();
            bool accepted = EditAction(action, elements);
            return accepted ? action : null;
        }

        public override bool EditAction(ShowSubwheelAction action, IWheelElements elements)
        {
            IWheel subwheel;
            if (action.SubWheel == null)
            {
                subwheel = elements.Editor.WheelEditor.AddWheel(elements);
                if (subwheel != null)
                {
                    action.SubWheel = subwheel;
                    return true;
                }
                else return false;
            }
            else
            {
                return elements.Editor.WheelEditor.EditWheel(action.SubWheel, elements);
            }
        }
    }
}
