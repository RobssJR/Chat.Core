namespace Core.Infra.Models.Chat
{
    public class ChatModel : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<MessageModel> Messages { get; set; }
    }
}
