using Database.Models;

namespace Core.Models.Client
{
    public class ClientModel : BaseEntity
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
