using Core.Infra;
using Core.Infra.Models.Chat;
using Core.Infra.Models.Client;

namespace Core.Services
{
    public class ChatService : BaseRepository<ChatModel>
    {
        public ChatService(string collectionName) : base(collectionName)
        {
        }

        public List<ChatModel> GetChatsByUser(ClientModel user)
        {
            List<ChatModel> chats = Query(chat => chat.Users.Contains(user)).ToList();
            return chats;
        }
    }
}
