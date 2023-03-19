using Core.Infra.Models.Client;

namespace Core.Infra.Models.Chat
{
    public class ChatModel : BaseEntity
    {
        public string Name { get; set; }
        public List<MessageModel> Messages { get; set; }
        public List<ClientModel> Users { get; set; }
    }
}
