using AutoMapper;
using Clinic_API.Models;
using Clinic_API.Services;
using ClinicQueriesAPI.Data;
using ClinicQueriesAPI.Entities;
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
               
                var usuario = ValidarCredenciales(authenticationRequestBody); 

                if (usuario is null) 
                    return Unauthorized();

                var claveDeSeguridad = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey"])); 

                var credenciales = new SigningCredentials(claveDeSeguridad, SecurityAlgorithms.HmacSha256);

                var claimsForToken = new List<Claim>();
                claimsForToken.Add(new Claim("sub", usuario.Id.ToString())); 
                claimsForToken.Add(new Claim("given_name", usuario.Name));
                claimsForToken.Add(new Claim("family_name", usuario.LastName)); 
                claimsForToken.Add(new Claim("role", authenticationRequestBody.UserType ?? "patient"));

                var jwtSecurityToken = new JwtSecurityToken(    
                  _config["Authentication:Issuer"],
                  _config["Authentication:Audience"],
                  claimsForToken,
                  DateTime.UtcNow,
                  DateTime.UtcNow.AddHours(1),
                  credenciales);

                var tokenToReturn = new JwtSecurityTokenHandler()
                    .WriteToken(jwtSecurityToken);

            if (authenticationRequestBody.UserType == "patient")
            {
                Patient? patient = _patientRepository.GetPatientByEmail(authenticationRequestBody.Email);
                patient.Token = tokenToReturn;
                return Ok(_mapper.Map<AuthPatientDto>(patient));
            }
            Doctor? doctor = _doctorRepository.GetDoctorByEmail(authenticationRequestBody.Email);
            doctor.Token = tokenToReturn;

            return Ok(_mapper.Map<AuthDoctorDto>(doctor));



            }



            private User? ValidarCredenciales(AuthenticationRequestBody parametrosAutenticacion)
            {
                return _autenticacionService.AuthenticateUser(parametrosAutenticacion);
            }
        }
}
