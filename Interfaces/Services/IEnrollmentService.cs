using Equb.Dtos;

namespace Equb.Interfaces.Services
{
    public interface IEnrollmentService
    {
        Task Create(EnrollmentCreateDto user);
    }
}
