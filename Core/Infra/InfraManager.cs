using Core.Services;

namespace Core.Infra
{
    public class InfraManager
    {
        private static InfraManager _instance;
        public ClientService _clientService = new ClientService("clientes");
        public ChatService _chatService = new ChatService("chats");

        private InfraManager() { }

        public static InfraManager GetInstance()
        {
            if (_instance == null)
                _instance = new InfraManager();
            return _instance;
        }
    }
}
