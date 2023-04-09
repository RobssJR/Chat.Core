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
            return Query(
                chat => chat.Users
                .Select(userChat => userChat.Id)
                .Any(id => id.Equals(user.Id)))
                .ToList();
        }

        public ChatModel GetChatById(string chatId)
        {
            List<ChatModel> chats = Query(chat => chat.Id == chatId).ToList();

            if (chats.Count == 0)
                return null;

            return chats.First();
        }
    }
}
