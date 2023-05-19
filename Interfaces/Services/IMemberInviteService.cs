namespace Equb.Interfaces.Services
{
    public interface IMemberInviteService
    {
        Task InviteMembers(int equbId, int inviterUserId, List<int> inviteeUsersId);
    }
}

