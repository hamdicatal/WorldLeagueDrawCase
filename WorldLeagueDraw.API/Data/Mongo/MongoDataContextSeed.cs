using MongoDB.Driver;
using WorldLeagueDraw.API.Entities;
using WorldLeagueDraw.API.Helpers;

namespace WorldLeagueDraw.API.Data.Mongo
{
    public class MongoDataContextSeed
    {
        public static void SeedData(IMongoCollection<Team> teamsCollection)
        {
            bool existTeams = teamsCollection.Find(p => true).Any();
            if (!existTeams)
            {
                teamsCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Team> GetPreconfiguredProducts()
        {
           return DummyDataHelper.GetDummyTeamList();
        }
    }
}
