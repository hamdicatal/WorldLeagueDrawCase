using Microsoft.EntityFrameworkCore;
using WorldLeagueDraw.API.Data;
using WorldLeagueDraw.API.Entities;
using WorldLeagueDraw.API.Repositories.Interfaces;

namespace WorldLeagueDraw.API.Repositories
{
    public class DrawRepository : IDrawRepository
    {
        private readonly DataContext _context;
        public DrawRepository(DataContext context)
        {
            _context = context;
        }
        public async Task CreateDrawResult(DrawResult drawResult)
        {
            _context.DrawResults.Add(drawResult);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Team>> GetAllTeams()
        {
            return await _context.Teams.ToListAsync();

        }

        public async Task<DrawResult> GetDrawResult(int id)
        {
            return await _context.DrawResults.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<DrawResult>> GetDrawResults()
        {
            return await _context.DrawResults.ToListAsync();
        }
    }
}
