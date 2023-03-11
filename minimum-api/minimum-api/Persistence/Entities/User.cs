using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace minimum_api.Persistence.Entities
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ProfileImageUrl { get; set; } = null!;
        public string Bio { get; set; } = null!;
        public string SessionId { get; set; } = null!;
    }
}
