using Core.Infra.Models.Client;

namespace Core.Infra.Models.Chat
{
    public class MessageModel : BaseEntity
    {
        public ClientModel Client { get; set; }
        public string Message { get; set; }
        public DateTime DataSend { get; set; }
    }
}
