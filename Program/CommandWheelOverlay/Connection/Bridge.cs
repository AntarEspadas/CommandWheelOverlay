using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace CommandWheelOverlay.Connection
{
    class Bridge
    {
        private NetworkStream stream;
        private object reciever;
        private BinaryFormatter formatter;
        public Bridge(NetworkStream stream, object reciever)
        {
            this.stream = stream;
            this.reciever = reciever;
            formatter = new BinaryFormatter();
            Task task = Task.Run(Recieve);
        }
        public void Pass([CallerMemberName] string caller = null, params object[] parameters)
        {
            Packet packet = new Packet(caller, parameters);
            formatter.Serialize(stream, packet);
        }

        private void Recieve()
        {
            while (true)
            {
                object obj = formatter.Deserialize(stream);
                if (obj is Packet packet)
                {
                    reciever.GetType().GetMethod(packet.TargetMehtod, packet.Parameters.Select(element => element.GetType()).ToArray()).Invoke(reciever, packet.Parameters);
                }
            }
        }
    }
}
