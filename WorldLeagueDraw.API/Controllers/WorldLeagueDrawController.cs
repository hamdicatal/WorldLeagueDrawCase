using Microsoft.AspNetCore.Mvc;
using WorldLeagueDraw.API.Business.Interfaces;
using WorldLeagueDraw.API.DTOs;

namespace WorldLeagueDraw.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorldLeagueDrawController : ControllerBase
    {
        private readonly ILogger<WorldLeagueDrawController> _logger;
        private readonly IDrawServices _drawServices;

        public WorldLeagueDrawController(ILogger<WorldLeagueDrawController> logger, IDrawServices drawServices)
        {
            _logger = logger;
            _drawServices = drawServices;
        }

        [HttpPost]
        public async Task<ActionResult<DrawResponseDTO>> Draw([FromBody]DrawRequestDTO request)
        {
            var drawResult = await _drawServices.Draw(request);

            if (drawResult == null)
                return NotFound();

            return Ok(drawResult);
        }
    }
}