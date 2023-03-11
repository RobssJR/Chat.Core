using LiteDB;

namespace Database.Models
{
    public class BaseEntity
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.NewObjectId();
    }
}
