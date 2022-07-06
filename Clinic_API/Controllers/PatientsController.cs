using AutoMapper;
using ClinicQueriesAPI.Data;
using ClinicQueriesAPI.Entities;
using ClinicQueriesAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClinicQueriesAPI.Controllers
{
    [Route("api/patients", Name = "GetPatients")]
    [ApiController]
    [Authorize]

    public class PatientsController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;

        public PatientsController(IPatientRepository patientRepository, IMapper mapper)
        {
            _patientRepository = patientRepository;
            _mapper = mapper;
        }


        [HttpGet]
        
        public ActionResult<List<PatientWithoutQueriesDto>> GetPatients()
        {
            var patients = _patientRepository.GetPatients();

            if (patients is null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<List<PatientWithoutQueriesDto>>(patients));
        }

        [HttpGet("{patientId}")]
        
        public ActionResult<PatientDto> GetPatient(int patientId)
        {
            var patient = _patientRepository.GetPatient(patientId);
            if (patient is null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PatientDto>(patient));
        }


        [HttpPut("{patientId}")]
        public ActionResult<PatientUpdateDto> UpdatePatient(int patientId, PatientUpdateDto patientUpdatedDto)
        {
            if (!_patientRepository.IsPatient(patientId))
            {
                return NotFound();
            }

            var patientToUpdate = _patientRepository.GetPatient(patientId);
            if (patientToUpdate is null)
                return NotFound();


            _mapper.Map(patientUpdatedDto, patientToUpdate);

            _patientRepository.SaveChanges();

            return NoContent();

        }

    }

    
}
