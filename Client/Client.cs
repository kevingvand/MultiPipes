using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Client
    {
        private string _serverName;
        public Common.PipeStream Stream { get; set; }
        public NamedPipeClientStream ClientStream { get; set; }

        public Client(string serverName)
        {
            _serverName = serverName;
            ClientStream = new NamedPipeClientStream(".", serverName, PipeDirection.InOut, PipeOptions.None, System.Security.Principal.TokenImpersonationLevel.Impersonation);
            Stream = new Common.PipeStream(ClientStream);
        }

        public void Connect()
        {
            ClientStream.Connect();
        }
    }
}
