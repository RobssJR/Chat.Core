using Core.Infra.Models.Client;

namespace Core.Models.Server
{
    public class ClientPortModel
    {
        public ClientModel Client { get; set; }
        public string IpPort { get; set; }
    }
}
