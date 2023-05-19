using AutoMapper;
using Equb.Dtos;
using Equb.Interfaces.Repositories;
using Equb.Interfaces.Services;
using Equb.Models;

namespace Equb.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly ICommonRepository _commonRepository;
        private readonly IMapper _mapper;

        public EnrollmentService(ICommonRepository commonRepository,
                                 IMapper mapper)
        {
            _commonRepository  = commonRepository;
            _mapper = mapper;
        }

        public async Task Create(EnrollmentCreateDto enrollment)
        {
            var newEnrollment = _mapper.Map<Enrollment>(enrollment);
            _commonRepository.Add(newEnrollment);
            await _commonRepository.SaveAll();
        }
    }
}
