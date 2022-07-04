using AutoMapper;
using Clinic_API.Models;
using ClinicQueriesAPI.Data;
using ClinicQueriesAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClinicQueriesAPI.Controllers
{

    [Route("api/doctors", Name = "GetDoctors")]
    [ApiController]
    [Authorize]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorsController(IDoctorRepository doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<List<DoctorWithoutQueriesDto>> GetDoctors()
        {
            var doctors = _doctorRepository.GetDoctors();

            if (doctors is null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<List<DoctorWithoutQueriesDto>>(doctors));
        }

        [HttpGet("{doctorId}")]
        public ActionResult<DoctorDto> GetDoctor(int doctorId)
        {
            var doctor = _doctorRepository.GetDoctor(doctorId);
            if (doctor is null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DoctorDto>(doctor));
        }

       
    }
}
