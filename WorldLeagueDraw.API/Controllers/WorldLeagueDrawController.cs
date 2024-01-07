using Microsoft.AspNetCore.Mvc;
using WorldLeagueDraw.API.DTOs;

namespace WorldLeagueDraw.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorldLeagueDrawController : ControllerBase
    {
        private readonly ILogger<WorldLeagueDrawController> _logger;

        public WorldLeagueDrawController(ILogger<WorldLeagueDrawController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public DrawResponseDTO Draw([FromBody]DrawRequestDTO request)
        {
            return null;
        }
    }
}