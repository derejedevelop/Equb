using Equb.Dtos;

namespace Equb.Interfaces.Services
{
    public interface IEqubService
    {
        Task Create(EqubCreateDto user);
    }
}
