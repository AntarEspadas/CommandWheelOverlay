using CommandWheelForms.Forms;
using CommandWheelOverlay.Input;
using CommandWheelOverlay.Settings;
using CommandWheelOverlay.View.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandWheelForms.Editors
{
    class SettingsEditor : ISettingsEditor
    {
        public bool EditSettings(IUserSettings userSettings, IInputHandler inputHandler)
        {
            inputHandler.PauseOutput = true;
            SettingsEditorForm form = new SettingsEditorForm(userSettings, inputHandler);
            bool result = form.ShowDialog() == DialogResult.OK;
            if (result)
            {
                userSettings.ShowHotkey = form.ShowHotkey;
                userSettings.MoveLeftHotkey = form.MoveLeftHotkey;
                userSettings.MoveRightHotkey = form.MoveRightHotkey;
                userSettings.Sensitivity = form.Sensitivity;
                inputHandler.LoadHotkeys(userSettings);
            }
            inputHandler.PauseOutput = false;
            return result;
        }
    }
}
