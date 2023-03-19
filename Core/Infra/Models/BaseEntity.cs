using LiteDB;

namespace Core.Infra.Models
{
    public class BaseEntity
    {
        [BsonId]
        public string Id { get; set; }
    }
}
