using Core.Services;

namespace Core.Infra
{
    public class InfraManager
    {
        private static InfraManager _instance;
        public ClientService _clientService = new ClientService("clientes");

        private InfraManager() { }

        public static InfraManager GetInstance()
        {
            if (_instance == null)
                _instance = new InfraManager();
            return _instance;
        }
    }
}
