using Equb.Dtos;
using Equb.Models;

namespace Equb.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<Users> GetUser(int id);
        void Add<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
