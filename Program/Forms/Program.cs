using System;
using System.Linq;
using System.Windows.Forms;
using Linearstar.Windows.RawInput;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using CommandWheelOverlay.Connection;
using CommandWheelOverlay.Input;
using CommandWheelForms.Forms;

namespace CommandWheelForms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}