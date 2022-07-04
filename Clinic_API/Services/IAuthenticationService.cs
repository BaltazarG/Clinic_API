using Clinic_API.Models;
using ClinicQueriesAPI.Entities;

namespace Clinic_API.Services
{
    public interface IAuthenticationService
    {
        public User? AuthenticateUser(AuthenticationRequestBody authenticationRequest, string userType);
    }
}
