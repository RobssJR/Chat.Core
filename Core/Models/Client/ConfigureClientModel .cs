using SuperSimpleTcp;

namespace Core.Models.Client
{
    public class ConfigureClientModel
    {
        public EventHandler<DataSentEventArgs> dataSentEvent;
        public EventHandler<DataReceivedEventArgs> dataReceivedEvent;
    }
}
