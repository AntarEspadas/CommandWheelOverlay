using CommandWheelOverlay.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandWheelOverlay.Controller
{
    class WheelButton : IWheelButton
    {
        public string Label { get; set; } = "Button";
        public string ImgPath { get; set; } = null;
        public IWheel SubWheel { get; set; } = null;
        public IWheelAction Action { get; set; } = null;

        public SimplifiedWheelButton Simplify(IList<IWheel> wheels)
        {
            return new SimplifiedWheelButton(Label, ImgPath, wheels.IndexOf(SubWheel), Action.Simplify());
        }
    }
}
