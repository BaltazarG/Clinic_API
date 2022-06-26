using Clinic_API.Data;
using Clinic_API.Models;
using ClinicQueriesAPI.Entities;

namespace Clinic_API.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository; 

        public AuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User? AuthenticateUser(AuthenticationRequestBody authenticationRequest)
        {
            if (String.IsNullOrEmpty(authenticationRequest.Email) || String.IsNullOrEmpty(authenticationRequest.Password))
                return null;
            return _userRepository.ValidateUser(authenticationRequest);
        }
        
    }
}
