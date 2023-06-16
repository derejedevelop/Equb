using Equb.Models;

namespace Equb.Interfaces.Repositories
{
    public interface IEqubRepository
    {
        Task<List<EqubInfo>> GetEqubByAdminId(int adminId);
        Task<EqubInfo> GetEqubByEqubId(int equbId);
        void Add<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
