using MongoDB.Driver;
using WorldLeagueDraw.API.Entities;

namespace WorldLeagueDraw.API.Data.Mongo
{
    public interface IMongoDataContext
    {
        IMongoCollection<DrawResult> DrawResults { get; }
    }
}
