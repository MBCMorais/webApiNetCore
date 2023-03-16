using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace webApiNetCore.Models
{
    [Serializable, BsonIgnoreExtraElements]
    public class Book
    {

        public Book()
        {
            this.Created = DateTime.UtcNow;
        }


        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        
        public string BookName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ISBN { get; set; } = null!;
        public double Price { get; set; }
        public string AuthorName { get; set; }

        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
        //public List<Author> Authors { get; set; } = null!;
        //public Category Category { get; set; }


    }
}
