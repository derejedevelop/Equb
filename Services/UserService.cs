using Equb.Interfaces.Services;
using Equb.Models;
using AutoMapper;
using Equb.Interfaces.Repositories;
using Equb.Dtos;

namespace Equb.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICommonRepository _commonRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository,
                           ICommonRepository commonRepository,
                           IMapper mapper)
        {
            _userRepository = userRepository;
            _commonRepository = commonRepository;
            _mapper = mapper;
        }
        public async Task Create(UserCreateDto user)
        {
            var newUser = _mapper.Map<Users>(user);
            _commonRepository.Add(newUser);
            await _commonRepository.SaveAll();
        }

        public async Task<UserBasicDto> GetUser(int userId)
        {
            return _mapper.Map<UserBasicDto>(await _userRepository.GetUser(userId));
        }
    }
}
