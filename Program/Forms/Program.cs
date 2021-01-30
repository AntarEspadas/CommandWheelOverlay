using System;
using System.Linq;
using System.Windows.Forms;
using Linearstar.Windows.RawInput;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using CommandWheelOverlay.Connection;
using CommandWheelOverlay.Input;

namespace CommandWheelForms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Application.Run(new MainWindow());
        }
    }
}