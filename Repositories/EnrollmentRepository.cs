using Equb.Data;
using Equb.Interfaces.Repositories;
using Equb.Models;
using Microsoft.EntityFrameworkCore;

namespace Equb.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly DataContext _context;

        public EnrollmentRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Enrollment>> GetEnrollmentByEqubId(int equbId)
        {
            return await _context.Enrollment.Where(x => x.EqubId == equbId).ToListAsync();
        }
    }
}
