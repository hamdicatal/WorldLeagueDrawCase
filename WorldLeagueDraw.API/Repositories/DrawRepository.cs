using Microsoft.EntityFrameworkCore;
using WorldLeagueDraw.API.Data.Mongo;
using WorldLeagueDraw.API.Data.MSSQL;
using WorldLeagueDraw.API.Entities;
using WorldLeagueDraw.API.Repositories.Interfaces;

namespace WorldLeagueDraw.API.Repositories
{
    public class DrawRepository : IDrawRepository
    {
        private readonly DataContext _context;
        private readonly IMongoDataContext _mongoDataContext;
        public DrawRepository(DataContext context, IMongoDataContext mongoDataContext)
        {
            _context = context;
            _mongoDataContext = mongoDataContext;
        }
        public async Task CreateDrawResult(DrawResult drawResult)
        {
            //_context.DrawResults.Add(drawResult);
            //await _context.SaveChangesAsync();
            await _mongoDataContext.DrawResults.InsertOneAsync(drawResult);
        }

        public async Task<IEnumerable<Team>> GetAllTeams()
        {
            return await _context.Teams.ToListAsync();

        }

        public async Task<DrawResult> GetDrawResult(int id)
        {
            //return await _context.DrawResults.Where(x => x.Id == id).FirstOrDefaultAsync();
            return null;
        }

        public async Task<IEnumerable<DrawResult>> GetDrawResults()
        {
            return await _context.DrawResults.ToListAsync();
        }
    }
}
