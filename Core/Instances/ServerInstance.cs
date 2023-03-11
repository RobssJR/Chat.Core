using Core.Models.Server;
using SuperSimpleTcp;

namespace Core.Instances
{
    public class ServerInstance
    {
        private static ServerInstance _serverInstance;
        public SimpleTcpServer server;

        private ServerInstance()
        {
            server = new SimpleTcpServer("127.0.0.1:23");
        }

        public void Start()
        {
            server.Start();
        }

        public void Configure(ConfigureServerModel configure)
        {
            server.Events.DataSent += configure.dataSentEvent;
            server.Events.DataReceived += configure.dataReceivedEvent;
            server.Events.ClientConnected += configure.connectionEvent;
            server.Events.ClientDisconnected += configure.desconnectionEvent;
        }

        public static ServerInstance GetInstance()
        {
            if (_serverInstance == null)
                _serverInstance = new ServerInstance();

            return _serverInstance;
        }
    }
}
