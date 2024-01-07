using MongoDB.Driver;
using WorldLeagueDraw.API.Data.Mongo;
using WorldLeagueDraw.API.Entities;
using WorldLeagueDraw.API.Repositories.Interfaces;

namespace WorldLeagueDraw.API.Repositories
{
    public class DrawRepository : IDrawRepository
    {
        private readonly IMongoDataContext _mongoDataContext;
        public DrawRepository(IMongoDataContext mongoDataContext)
        {
            _mongoDataContext = mongoDataContext;
        }
        public async Task CreateDrawResult(DrawResult drawResult)
        {
            await _mongoDataContext.DrawResults.InsertOneAsync(drawResult);
        }

        public async Task<IEnumerable<DrawResult>> GetDrawResults()
        {
            return await _mongoDataContext.DrawResults.Find(p => true).ToListAsync();
        }

        public async Task<IEnumerable<Team>> GetAllTeams()
        {
            return await _mongoDataContext.Teams.Find(p => true).ToListAsync();
        }
    }
}
