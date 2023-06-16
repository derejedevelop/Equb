using Equb.Data;
using Equb.Dtos;
using Equb.Interfaces.Repositories;
using Equb.Models;
using Microsoft.EntityFrameworkCore;

namespace Equb.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public async Task<Users> GetUserByUserId(int id)
        {
            return await _context.Users.Where(x => x.UsersId == id).FirstOrDefaultAsync();
        }

        public async Task<Users> GetUserByUserName(string userName)
        { 
            return await _context.Users.Where(x => x.UserName.ToLower() == userName.ToLower()).FirstOrDefaultAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
