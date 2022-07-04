using AutoMapper;
using Clinic_API.Models;
using Clinic_API.Services;
using ClinicQueriesAPI.Data;
using ClinicQueriesAPI.Entities;
using ClinicQueriesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Clinic_API.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        
        
            private readonly IConfiguration _config;
            private readonly IAuthenticationService _autenticacionService;
            private readonly IPatientRepository _patientRepository;
            private readonly IDoctorRepository _doctorRepository;
            private readonly IMapper _mapper;

        public AuthenticationController(IConfiguration config, IAuthenticationService autenticacionService, IPatientRepository patientRepository, IDoctorRepository doctorRepository, IMapper mapper)
        {
            _config = config;
            _autenticacionService = autenticacionService;
            _patientRepository = patientRepository;
            _doctorRepository = doctorRepository;
            _mapper = mapper;

        }

        [HttpPost("login")]
            public ActionResult<AuthPatientDto> Autenticar(AuthenticationRequestBody authenticationRequestBody) 
            {
            string userType;



            var claveDeSeguridad = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey"]));

            var credenciales = new SigningCredentials(claveDeSeguridad, SecurityAlgorithms.HmacSha256);

            
                Patient? user = _patientRepository.GetPatientByEmail(authenticationRequestBody.Email);

                if (user != null)
                {
                    userType = "patient";
                } else
                {
                    userType = "doctor";
                }

                var usuario = ValidarCredenciales(authenticationRequestBody, userType);
                if (usuario is null) 
                    return Unauthorized();

                var claimsForToken = new List<Claim>();
                claimsForToken.Add(new Claim("sub", usuario.Id.ToString()));
                claimsForToken.Add(new Claim("given_name", usuario.Name));
                claimsForToken.Add(new Claim("family_name", usuario.LastName));
                claimsForToken.Add(new Claim("role", userType));

                var jwtSecurityToken = new JwtSecurityToken(    
                  _config["Authentication:Issuer"],
                  _config["Authentication:Audience"],
                  claimsForToken,
                  DateTime.UtcNow,
                  DateTime.UtcNow.AddHours(1),
                  credenciales);

                var tokenToReturn = new JwtSecurityTokenHandler()
                    .WriteToken(jwtSecurityToken);

            

            if (userType == "patient")
            {
                Patient? patient = _patientRepository.GetPatientByEmail(authenticationRequestBody.Email);
                patient.Token = tokenToReturn;
                return Ok(_mapper.Map<AuthPatientDto>(patient));
            }
            Doctor? doctor = _doctorRepository.GetDoctorByEmail(authenticationRequestBody.Email);
            doctor.Token = tokenToReturn;

            return Ok(_mapper.Map<AuthDoctorDto>(doctor));

            }


            [HttpPost("signup")]
            public ActionResult<AuthPatientDto> RegisterPatient(PatientCreationDto patientToCreate)
            {


            Patient newPatient = _mapper.Map<Patient>(patientToCreate);
            

            _patientRepository.AddPatient(newPatient);
            _patientRepository.SaveChanges();

            var claveDeSeguridad = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey"]));
            var credenciales = new SigningCredentials(claveDeSeguridad, SecurityAlgorithms.HmacSha256);
            var claimsForToken = new List<Claim>();

            claimsForToken.Add(new Claim("sub", newPatient.Id.ToString()));
            claimsForToken.Add(new Claim("given_name", newPatient.Name));
            claimsForToken.Add(new Claim("family_name", newPatient.LastName));
            claimsForToken.Add(new Claim("role", patientToCreate.UserType));

            var jwtSecurityToken = new JwtSecurityToken(
                  _config["Authentication:Issuer"],
                  _config["Authentication:Audience"],
                  claimsForToken,
                  DateTime.UtcNow,
                  DateTime.UtcNow.AddHours(1),
                  credenciales);    

            var tokenToReturn = new JwtSecurityTokenHandler()
                    .WriteToken(jwtSecurityToken);    


            newPatient.Token = tokenToReturn;
                
                
            return CreatedAtRoute("GetPatients",
                       new
                       {
                           patientId = newPatient.Id
                       },
                       _mapper.Map<AuthPatientDto>(newPatient));    



        }

        



        private User? ValidarCredenciales(AuthenticationRequestBody parametrosAutenticacion, string userType)
            {
                return _autenticacionService.AuthenticateUser(parametrosAutenticacion, userType);
            }
        }
}
