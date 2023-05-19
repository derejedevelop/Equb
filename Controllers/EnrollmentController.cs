using Equb.Dtos;
using Equb.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Equb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;
        public EnrollmentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [HttpPost]
        [Route("/api/Enrollment/Create")]
        public async Task<ActionResult> Create(EnrollmentCreateDto enrollment)
        {
            await _enrollmentService.Create(enrollment);
            return Ok();
        }
    }
}
