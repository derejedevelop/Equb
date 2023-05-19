using AutoMapper;
using Equb.Dtos;
using Equb.Interfaces.Repositories;
using Equb.Interfaces.Services;
using Equb.Models;

namespace Equb.Services
{
    public class MemberInviteService : IMemberInviteService
    {
        private readonly IMemberInviteRepository _memberInviteRepository;
        private readonly ICommonRepository _commonRepository;
        private readonly IMapper _mapper;

        public MemberInviteService(IMemberInviteRepository memberInviteRepository,
                                   ICommonRepository commonRepository,     
                                   IMapper mapper)
        {
            _memberInviteRepository = memberInviteRepository;
            _commonRepository = commonRepository;
            _mapper = mapper;
        }
        public async Task InviteMembers(int equbId, int inviterUserId, List<int> inviteeUsersId)
        {
            foreach(int i in inviteeUsersId)
            {
                var userInvite = new MemberInviteDto
                {
                    EqubId = equbId,
                    InviterUserId = inviterUserId,
                    InviteeUserId = i
                };

                var newUserInvite = _mapper.Map<MemberInvite>(userInvite);
                _commonRepository.Add(newUserInvite);
            }

            await _commonRepository.SaveAll();
        }
    }
}
