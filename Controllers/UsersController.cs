using Equb.Dtos;
using Equb.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Equb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("/api/Users/Create")]
        public async Task<ActionResult> Create(UserCreateDto user)
        {
            await _userService.Create(user);
            return Ok();
        }

        [HttpGet]
        [Route("/api/Users/GetUser")]
        public async Task<ActionResult<UserBasicDto>> GetUser(int userId)
        {
            return await _userService.GetUser(userId);
        }
    }
}
