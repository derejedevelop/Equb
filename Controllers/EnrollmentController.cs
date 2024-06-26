﻿using Equb.Dtos;
using Equb.Interfaces.Services;
using Equb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Equb.Controllers
{
    //Testing the pipeline trigger setup
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

        [HttpGet]
        [Route("/api/Enrollment/GetByEqubId")]
        public async Task<ActionResult<List<Enrollment>>> GetEnrollmentsByEqubId(int equbId)
        {
            return await _enrollmentService.GetEnrollmentsByEqubId(equbId);
        }
    }
}
