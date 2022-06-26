using Clinic_API.Models;
using Clinic_API.Services;
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

            public AuthenticationController(IConfiguration config, IAuthenticationService autenticacionService)
            {
                _config = config;
                _autenticacionService = autenticacionService;
            }

            [HttpPost("autenticar")]
            public ActionResult<string> Autenticar(AuthenticationRequestBody authenticationRequestBody) 
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

                return Ok(tokenToReturn);
            }

            private User? ValidarCredenciales(AuthenticationRequestBody parametrosAutenticacion)
            {
                return _autenticacionService.AuthenticateUser(parametrosAutenticacion);
            }
        }
}
