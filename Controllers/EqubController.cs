using Equb.Dtos;
using Equb.Interfaces.Services;
using Equb.Models;
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

        [HttpGet]
        [Route("/api/EqubInfo/GetByAdmin")]
        public async Task<ActionResult<List<EqubInfo>>> GetEqubByAdmin(int adminId)
        {
            return await _equbService.GetEqubListByAdmin(adminId);
        }

        [HttpGet]
        [Route("/api/EqubInfo/GetById")]
        public async Task<EqubInfo> GetEqubByID(int equbId)
        {
            return await _equbService.GetEqubByEqubId(equbId);
        }
    }
}
