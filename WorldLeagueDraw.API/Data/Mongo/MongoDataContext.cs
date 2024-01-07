using Microsoft.AspNetCore.SignalR.Protocol;
using MongoDB.Driver;
using WorldLeagueDraw.API.Entities;

namespace WorldLeagueDraw.API.Data.Mongo
{
    public class MongoDataContext : IMongoDataContext
    {
        public MongoDataContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            DrawResults = database.GetCollection<DrawResult>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            //MongoDataContextSeed.SeedData(DrawResults);
        }

        public IMongoCollection<DrawResult> DrawResults { get; }
    }
}
