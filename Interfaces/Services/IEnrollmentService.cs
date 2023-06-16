using Equb.Dtos;
using Equb.Models;

namespace Equb.Interfaces.Services
{
    public interface IEnrollmentService
    {
        Task Create(EnrollmentCreateDto user);
        Task<List<Enrollment>> GetEnrollmentsByEqubId(int equbId);
    }
}
