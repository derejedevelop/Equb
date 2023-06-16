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
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly ICommonRepository _commonRepository;
        private readonly IEqubRepository _equbRepository;
        private readonly IMapper _mapper;

        public MemberInviteService(IMemberInviteRepository memberInviteRepository,
                                   IEnrollmentRepository enrollmentRepository,
                                   ICommonRepository commonRepository,  
                                   IEqubRepository equbRepository,
                                   IMapper mapper)
        {
            _memberInviteRepository = memberInviteRepository;
            _enrollmentRepository = enrollmentRepository;
            _commonRepository = commonRepository;
            _equbRepository = equbRepository;
            _mapper = mapper;
        }

        public async Task InvitationAccepted(int invitationId, bool accepted)
        {
            MemberInvite invitation = await _memberInviteRepository.GetInvitationById(invitationId);

            invitation.Accepted = accepted;

            _commonRepository.Update(invitation);
            await _commonRepository.SaveAll();

            EnrollmentCreateDto newEnrollment = new EnrollmentCreateDto
            {
                EqubId = invitation.EqubId,
                UserId = invitation.InviteeUserId
            };

            var enroll = _mapper.Map<Enrollment>(newEnrollment);
            _commonRepository.Add(enroll);
            await _commonRepository.SaveAll();
        }

        public async Task InviteMembers(int equbId, int inviterUserId, List<int> inviteeUsersId)
        {
            EqubInfo equb = await _equbRepository.GetEqubByEqubId(equbId);

            if(equb == null)
            {
                Console.WriteLine("Equb id not found");
            }
            else
            {
                List<Enrollment> enrollments = await _enrollmentRepository.GetEnrollmentByEqubId(equbId);

                foreach (int i in inviteeUsersId)
                {
                    Enrollment enrollment = enrollments.Find(x => x.EqubId == i);

                    if (enrollment == null)
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
                }

                await _commonRepository.SaveAll();
            }
        }
    }
}
