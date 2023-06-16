using Equb.Models;

namespace Equb.Interfaces.Repositories
{
    public interface IMemberInviteRepository
    {
        Task<MemberInvite> GetInvitationById(int id);
        void Add<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
