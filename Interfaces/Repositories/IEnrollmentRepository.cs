using Equb.Models;

namespace Equb.Interfaces.Repositories
{
    public interface IEnrollmentRepository
    {
        Task<List<Enrollment>> GetEnrollmentByEqubId(int equbId);
    }
}
