using Core.Models;
using Core.Models.Client;
using Core.Services;
using SuperSimpleTcp;

namespace Core.Instances
{
    public class ClientInstance
    {
        private static ClientInstance _clientInstance;
        public SimpleTcpClient client;

        private ClientInstance()
        {
            client = new SimpleTcpClient("127.0.0.1:23");
        }

        public void Start()
        {
            try
            {
                client.Connect();
            } catch
            { }
        }

        public void Configure(ConfigureClientModel configure)
        {
            client.Events.DataSent += configure.dataSentEvent;
            client.Events.DataReceived += configure.dataReceivedEvent;
        }

        public void Send<T>(TCPMessageModel<T> messageObj)
        {
            string messsageJson = Util.JsonUtil.ConvertToJson(messageObj);

            _clientInstance.client.Send(messsageJson);
        }

        public static ClientInstance GetInstance()
        {
            if (_clientInstance == null)
                _clientInstance = new ClientInstance();

            return _clientInstance;
        }
    }
}
