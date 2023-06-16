using Equb.Dtos;
using Equb.Models;

namespace Equb.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<Users> GetUserByUserName(string userName);
        Task<Users> GetUserByUserId(int id);
        void Add<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
