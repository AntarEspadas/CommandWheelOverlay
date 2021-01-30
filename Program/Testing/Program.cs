using System;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using CommandWheelOverlay.Connection;
using CommandWheelOverlay.View;
using CommandWheelOverlay.Input;
using CommandWheelOverlay.Settings;

namespace Testing
{
    class Program
    {
        static readonly string location = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        static string pipeName = "CommandWheelOverlayPipeName";
        static void Main(string[] args)
        {
            OverlayView view = new OverlayView();
            TcpOverlayController controller = new TcpOverlayController(view, 7777);
            controller.Connect();
            while (true)
            {

            }
        }
    }

    class OverlayView : IOverlayView
    {
        public void SendInput(KeyboardInput input)
        {
            Console.WriteLine(input.ToString());
        }

        public void SendInput(MouseInput input)
        {
            Console.WriteLine(input.ToString());
        }

        public void UpdateElements(SimplifiedWheelElements elements)
        {
            throw new NotImplementedException();
        }

        public void UpdateSettings(IUserSettings settings)
        {
            throw new NotImplementedException();
        }
    }
}
