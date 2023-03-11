using SuperSimpleTcp;

namespace Core.Models.Server
{
    public class ConfigureServerModel
    {
        public EventHandler<DataSentEventArgs> dataSentEvent;
        public EventHandler<DataReceivedEventArgs> dataReceivedEvent;
        public EventHandler<ConnectionEventArgs> connectionEvent;
        public EventHandler<ConnectionEventArgs> desconnectionEvent;
    }
}
