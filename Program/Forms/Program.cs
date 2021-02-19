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
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CommandWheelForms
{
    public class Program
    {
        public static readonly string programPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        
        [STAThread]
        public static void Main(string[] args)
        {
            string guid = ((GuidAttribute)Assembly.GetExecutingAssembly()
                .GetCustomAttributes(typeof(GuidAttribute), false)
                .GetValue(0)).Value.ToString();

            Mutex mutex = new Mutex(false, guid);

            bool hasMutex;

            try
            {
                hasMutex = mutex.WaitOne(100);
            }
            catch (AbandonedMutexException)
            {
                hasMutex = true;
            }

            if (!hasMutex) return;

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
    }
}