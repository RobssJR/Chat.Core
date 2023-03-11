using Core.Infra;
using Core.Infra.Models.Client;

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
    }
}
