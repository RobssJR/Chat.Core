using Core.Infra;
using Core.Infra.Models.Chat;
using Core.Infra.Models.Client;
using Core.Models.Exception;

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
                throw new ErrorHandled("Não foi posisvel encontrar nenhum chat");

            return chats.First();
        }

        public void AddChat(ChatModel chat)
        {
            if (Query(x => x.Name == chat.Name).FirstOrDefault() != null)
                throw new ErrorHandled("Erro, chat já criado");

            Add(chat);
        }
    }
}
