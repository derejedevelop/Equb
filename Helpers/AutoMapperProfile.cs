using AutoMapper;
using Equb.Dtos;
using Equb.Models;

namespace Equb.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserCreateDto, Users>();
            CreateMap<EqubCreateDto, EqubInfo>();
            CreateMap<MemberInviteDto, MemberInvite>();
            CreateMap<EnrollmentCreateDto, Enrollment>();
            CreateMap<Users, UserBasicDto>();
            CreateMap<InvitationAcceptedDto, MemberInvite>();
        }
    }
}
