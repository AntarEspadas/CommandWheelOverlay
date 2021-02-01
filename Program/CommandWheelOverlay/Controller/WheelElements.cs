using CommandWheelOverlay.View;
using CommandWheelOverlay.View.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandWheelOverlay.Controller
{
    public class WheelElements : IWheelElements
    {
        public IElementsEditor Editor { get; set; }
        public IList<IWheel> Wheels { get; set; } = new List<IWheel>();
        public IList<IWheelButton> Buttons { get; set; } = new List<IWheelButton>();

        public object Clone()
        {
            WheelElements clone = new WheelElements
            {
                Wheels = new List<IWheel>(Wheels.Count),
                Buttons = new List<IWheelButton>(Buttons.Count),
                Editor = Editor
            };
            var wheelsDict = new Dictionary<IWheel, int>();
            var buttonsDict = new Dictionary<IWheelButton, int>();
            for (int i = 0; i < Wheels.Count; i++)
            {
                wheelsDict[Wheels[i]] = i;
                clone.Wheels.Add((IWheel)Wheels[i].Clone());
            }
            for (int i = 0; i < Buttons.Count; i++)
            {
                buttonsDict[Buttons[i]] = i;
                clone.Buttons.Add((IWheelButton)Buttons[i].Clone());
            }
            foreach (IWheel wheel in clone.Wheels)
                for (int i = 0; i < wheel.Buttons.Count; i++)
                {
                    IWheelButton button = wheel.Buttons[i];
                    int buttonIndex = buttonsDict[button];
                    wheel.Buttons[i] = clone.Buttons[buttonIndex];
                }
            foreach (IWheelButton button in clone.Buttons)
            {
                if (button.Action is null) continue;
                int wheelIndex = wheelsDict[button.Action.SubWheel];
                button.Action.SubWheel = clone.Wheels[wheelIndex];
            }
            return clone;
        }

        public SimplifiedWheelElements Simplify()
        {
            var simplifiedWheels = Wheels.Select(element => element.Simplify(Buttons)).ToArray();
            var simplifiedButtons = Buttons.Select(element => element.Simplify(Wheels)).ToArray();
            return new SimplifiedWheelElements(simplifiedWheels, simplifiedButtons);
        }
    }
}
