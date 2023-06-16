using AutoMapper;
using Equb.Dtos;
using Equb.Interfaces.Repositories;
using Equb.Interfaces.Services;
using Equb.Models;

namespace Equb.Services
{
    public class EqubService : IEqubService
    {
        private readonly IEqubRepository _equbRepository;
        private readonly ICommonRepository _commonRepository;
        private readonly IMapper _mapper;

        public EqubService(IEqubRepository userRepository,
                           ICommonRepository commonRepository,
                           IMapper mapper)
        {
            _equbRepository = userRepository;
            _commonRepository = commonRepository;
            _mapper = mapper;
        }
        public async Task Create(EqubCreateDto user)
        {
            var newEqub = _mapper.Map<EqubInfo>(user);
            _commonRepository.Add(newEqub);
            await _commonRepository.SaveAll();
        }

        public async Task<EqubInfo> GetEqubByEqubId(int equbId)
        {
            return await _equbRepository.GetEqubByEqubId(equbId);
        }

        public async Task<List<EqubInfo>> GetEqubListByAdmin(int adminId)
        {
            return await _equbRepository.GetEqubByAdminId(adminId);
        }
    }
}
