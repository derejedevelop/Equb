using Equb.Dtos;
using Equb.Models;

namespace Equb.Interfaces.Services
{
    public interface IEqubService
    {
        Task Create(EqubCreateDto user);

        Task<List<EqubInfo>> GetEqubListByAdmin(int adminId);
        Task<EqubInfo> GetEqubByEqubId(int equbId);
    }
}
