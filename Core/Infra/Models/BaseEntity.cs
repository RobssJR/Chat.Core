using LiteDB;

namespace Core.Infra.Models
{
    public class BaseEntity
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.NewObjectId();
    }
}
