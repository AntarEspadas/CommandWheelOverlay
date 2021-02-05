using CommandWheelOverlay.Settings;
using CommandWheelOverlay.View;
using CommandWheelOverlay.View.Editors;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Controller
{
    public class OverlayController : IOverlayController
    {
        public IOverlayView View { get; set; }

        public IWheelElements Elements => elements;
        private IWheelElements elements;

        public IUserSettings Settings => settings;
        private IUserSettings settings;

        public OverlayController()
        {

        }

        public OverlayController(IWheelElements elements, IUserSettings settings)
        {
            this.elements = elements;
            this.settings = settings;
        }

        public void PerformAction(int actionIndex)
        {
            Elements.Buttons[actionIndex].Action.Perform();
        }

        public void UpdateElements()
        {
            IWheelElements copy = (IWheelElements)Elements.Clone();
            IWheelElements newElements = Elements.Editor.Edit(copy);
            if (newElements != null)
            {
                View.UpdateElements(new SimplifiedWheelElements(newElements));
                elements = newElements;
            }
        }

        public void UpdateSettings()
        {
            IUserSettings copy = (IUserSettings)Settings.Clone();
            IUserSettings newSettings = Settings.Editor.EditSettings(copy);
            if (newSettings != null)
            {
                View.UpdateSettings(Settings);
                settings = newSettings;
            }
        }
    }
}
