using Equb.Dtos;
using Equb.Models;

namespace Equb.Interfaces.Services
{
    public interface IUserService
    {
        Task Create(UserCreateDto user);
        Task<UserBasicDto> GetUser(int userId);
    }
}
