using WorldLeagueDraw.API.Entities;

namespace WorldLeagueDraw.API.Repositories.Interfaces
{
    public interface IDrawRepository
    {
        Task<IEnumerable<DrawResult>> GetDrawResults();
        Task CreateDrawResult(DrawResult drawResult);
        Task<IEnumerable<Team>> GetAllTeams();
    }
}
