using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WorldLeagueDraw.API.Entities
{
    public class Group
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string GroupName { get; set; }
        public List<Team> Teams { get; set; }
    }
}
