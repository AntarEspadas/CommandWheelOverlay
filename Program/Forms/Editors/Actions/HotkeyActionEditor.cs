using CommandWheelForms.Forms.Actions;
using CommandWheelOverlay.AdditionalActions;
using CommandWheelOverlay.Controller;
using CommandWheelOverlay.View.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandWheelForms.Editors.Actions
{
    public class HotkeyActionEditor : ActionEditor<HotkeyAction>
    {
        public override string DisplayName => "Send Hotkey";

        public override HotkeyAction CreateAction(IWheelElements elements)
        {
            var action = new HotkeyAction();
            bool accepted = EditAction(action, elements);
            return accepted ? action : null;
        }

        public override bool EditAction(HotkeyAction action, IWheelElements elements)
        {
            var form = new HotkeyActionEditorForm(action);
            if (form.ShowDialog() == DialogResult.OK)
            {
                action.SetHotkey(form.Keys);
                return true;
            }
            return false;
        }
    }
}
