using CommandWheelOverlay.Input;
using CommandWheelOverlay.Model;
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

        public IOverlayModel Model { get; set; }

        public IInputHandler InputHandler { get; set; }

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
            try
            {
                Elements.Buttons[actionIndex].Action.Perform();
            }
            catch (Exception)
            {
            }
        }

        public void UpdateElements()
        {
            IWheelElements copy = (IWheelElements)Elements.Clone();
            IWheelElements newElements = Elements.Editor.Edit(copy);
            if (newElements != null)
            {
                View.UpdateElements(new SimplifiedWheelElements(newElements));
                elements = newElements;
                Model.SaveElements(elements);
            }
        }

        public void UpdateSettings()
        {
            bool accepted = Settings.Editor.EditSettings(settings, InputHandler);
            if (accepted)
            {
                Model.SaveSettings(settings);
            }
        }
    }
}
