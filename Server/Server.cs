using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private string _serverName;
        public Common.PipeStream Stream { get; set; }
        public NamedPipeServerStream ServerStream { get; set; }

        public Server(string serverName)
        {
            _serverName = serverName;
            ServerStream = new NamedPipeServerStream(serverName, PipeDirection.InOut, 1);
            Stream = new Common.PipeStream(ServerStream);
        }

        public void WaitForConnection()
        {
            ServerStream.WaitForConnection();
        }
    }
}
