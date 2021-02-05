using System;
using System.Collections.Generic;
using System.Text;
using CommandWheelOverlay.View;

namespace CommandWheelOverlay.Controller
{
    public interface IWheelButton : ICloneable
    {
        string Label { get; set; }
        string ImgPath { get; set; }
        IWheelAction Action { get; set; }
    }
}
