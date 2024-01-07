using WorldLeagueDraw.API.DTOs;

namespace WorldLeagueDraw.API.Business.Interfaces
{
    public interface IDrawServices
    {
        Task<DrawResponseDTO> Draw(DrawRequestDTO request);
    }
}
