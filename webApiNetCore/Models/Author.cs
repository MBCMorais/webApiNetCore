using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace webApiNetCore.Models
{
    public class Author
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string? AuthorName { get; set; }

    }
}
