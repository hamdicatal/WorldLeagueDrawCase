using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WorldLeagueDraw.API.Entities
{
    public class DrawResult
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string NameSurname { get; set; }
        public List<Group> Groups { get; set; }
    }
}
