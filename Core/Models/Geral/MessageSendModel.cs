using Core.Models;

namespace Core.Models.Geral
{
    public class MessageSendModel
    {
        public string Message { get; set; }
        public ChatModel ChatReceived { get; set; }
        public ClientModel ClientSent { get; set; }
    }
}
