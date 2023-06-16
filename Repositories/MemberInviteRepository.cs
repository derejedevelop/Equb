using Equb.Data;
using Equb.Interfaces.Repositories;
using Equb.Models;
using Microsoft.EntityFrameworkCore;

namespace Equb.Repositories
{
    public class MemberInviteRepository : IMemberInviteRepository
    {
        private readonly DataContext _context;

        public MemberInviteRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public async Task<MemberInvite> GetInvitationById(int id)
        {
            return await _context.MemberInvites.Where(x => x.MemberInviteId == id).FirstOrDefaultAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
