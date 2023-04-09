using Core.Infra.Models.Chat;

namespace Core.Models.Geral
{
    public class AddUserChatModel
    {
        public ChatModel Chat { get; set; }
        public string Email { get; set; }
    }
}
