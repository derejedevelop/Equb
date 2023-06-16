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
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IMapper _mapper;

        public EnrollmentService(ICommonRepository commonRepository,
                                IEnrollmentRepository enrollmentRepository, 
                                 IMapper mapper)
        {
            _commonRepository  = commonRepository;
            _enrollmentRepository = enrollmentRepository;
            _mapper = mapper;
        }

        public async Task Create(EnrollmentCreateDto enrollment)
        {
            var newEnrollment = _mapper.Map<Enrollment>(enrollment);
            _commonRepository.Add(newEnrollment);
            await _commonRepository.SaveAll();
        }

        public async Task<List<Enrollment>> GetEnrollmentsByEqubId(int equbId)
        {
            return await _enrollmentRepository.GetEnrollmentByEqubId(equbId);
        }
    }
}
