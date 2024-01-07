using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WorldLeagueDraw.API.Entities
{
    public class Team
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
