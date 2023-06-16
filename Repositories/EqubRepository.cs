using Equb.Data;
using Equb.Interfaces.Repositories;
using Equb.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Equb.Repositories
{
    public class EqubRepository : IEqubRepository
    {
        private readonly DataContext _context;

        public EqubRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public async Task<List<EqubInfo>> GetEqubByAdminId(int adminId)
        {
            return await _context.EqubInfo.Where(x => x.AdminId == adminId).ToListAsync();
        }

        public async Task<EqubInfo> GetEqubByEqubId(int equbId)
        {
            return await _context.EqubInfo.Where(x => x.EqubInfoId == equbId).FirstOrDefaultAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
