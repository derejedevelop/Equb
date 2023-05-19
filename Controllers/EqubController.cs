using Equb.Dtos;
using Equb.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Equb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EqubController : ControllerBase
    {
        private readonly IEqubService _equbService;

        public EqubController(IEqubService equbService)
        {
            _equbService = equbService;
        }

        [HttpPost]
        [Route("/api/EqubInfo/Create")]
        public async Task<ActionResult> Create(EqubCreateDto equb)
        {
            await _equbService.Create(equb);
            return Ok();
        }
    }
}
