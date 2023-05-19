using Equb.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Equb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberInviteController : ControllerBase
    {
        private readonly IMemberInviteService _memberInviteService;
        public MemberInviteController(IMemberInviteService memberInviteService)
        {
            _memberInviteService = memberInviteService;
        }

        [HttpPost]
        [Route("/api/Members/Invite")]
        public async Task<ActionResult> InviteMembers(int equbId, int inviterUserId, List<int> inviteeUsersId)
        {
            await _memberInviteService.InviteMembers(equbId, inviterUserId, inviteeUsersId);
            return Ok();
        }
    }
}
