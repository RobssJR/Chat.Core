using Core.Infra;
using Core.Infra.Models.Client;
using Core.Models.Exception;

namespace Core.Services
{
    public class ClientService : BaseRepository<ClientModel>
    {
        public ClientService(string collectionName) : base(collectionName)
        {
        }
        public List<ClientModel> GetClieteByName(string name)
        {
            return Query(x => x.Name == name);
        }

        public void UserRegister(ClientModel client)
        {
            try
            {
                List<ClientModel> clients = GetClieteByName(client.Name);

                if (clients.Count > 0)
                    throw new ErrorHandled("Falha no cadastro, cadastro já existente");

               Add(client);
            }
            catch { throw; }
        }

        public ClientModel UserLogin(ClientModel client)
        {
            try
            {
                List<ClientModel> clients = Query(x =>
                    x.Email.ToLower() == client.Email.ToLower() &&
                    x.Password.ToLower() == client.Password.ToLower()).ToList();

                if (clients == null || clients.Count <= 0)
                    throw new ErrorHandled("Login ou senha incorretos");

                return clients.First();
            }
            catch { throw; }
        }

        public ClientModel GetClientByEmail(string email)
        {
            ClientModel client = Query(client => client.Email == email).First();

            if (client == null)
                throw new ErrorHandled("Usuário não encontrado");

            return client;
        }
    }
}
