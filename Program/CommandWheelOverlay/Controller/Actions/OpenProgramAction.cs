using CommandWheelOverlay.View;
using System;
using System.Diagnostics;

namespace CommandWheelOverlay.Controller.Actions
{
    class OpenProgramAction : IWheelAction
    {
        public string ProgramPath { get; set; }
        public string Arguments { get; set; }
        public void Perform()
        {
            Process process = new Process();
            process.StartInfo.FileName = ProgramPath;
            process.StartInfo.Arguments = Arguments;
            process.Start();
        }

        public SimplifiedWheelAction Simplify()
        {
            return new SimplifiedWheelAction(2);
        }
    }
}
