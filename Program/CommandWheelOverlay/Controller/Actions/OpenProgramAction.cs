using CommandWheelOverlay.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CommandWheelOverlay.Controller.Actions
{
    public class OpenProgramAction : IWheelAction
    {
        public string ProgramPath { get; set; }
        public string Arguments { get; set; }
        public IWheel SubWheel { get => null; set => throw new NotSupportedException(); }

        public object Clone()
        {
            return (OpenProgramAction)MemberwiseClone();
        }

        public void Perform()
        {
            Process process = new Process();
            process.StartInfo.FileName = ProgramPath;
            process.StartInfo.Arguments = Arguments;
            process.Start();
        }
    }
}
