using Equb.Data;
using Equb.Interfaces.Repositories;

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

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
