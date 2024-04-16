using Equb.Dtos;
using Equb.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Equb.Controllers
{
    //Pipeline trigger test
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
        [Route("/api/Users/GetUser/UserName")]
        public async Task<ActionResult<UserBasicDto>> GetUser(string userName)
        {
            return await _userService.GetUserByUserName(userName);
        }

        [HttpGet]
        [Route("/api/Users/GetUser/Id")]
        public async Task<ActionResult<UserBasicDto>> GetUser(int id)
        {
            return await _userService.GetUserByUserId(id);
        }
    }
}
