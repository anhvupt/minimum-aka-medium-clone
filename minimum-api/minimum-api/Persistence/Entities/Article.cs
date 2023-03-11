using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace minimum_api.Persistence.Entities
{
    public class Article
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; } = null;
        public string Slug { get; set; } = null!;
        public string AuthorId { get; set; } = null!;
        public IList<BsonDocument> Blocks = new List<BsonDocument>();
    }
}
