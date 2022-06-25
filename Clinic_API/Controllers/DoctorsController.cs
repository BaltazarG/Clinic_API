using AutoMapper;
using ClinicQueriesAPI.Data;
using ClinicQueriesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicQueriesAPI.Controllers
{

    [Route("api/doctors", Name = "GetDoctors")]
    [ApiController]
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
        public ActionResult<List<DoctorDto>> GetDoctors()
        {
            var doctors = _doctorRepository.GetDoctors();

            if (doctors is null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<List<DoctorDto>>(doctors));
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
