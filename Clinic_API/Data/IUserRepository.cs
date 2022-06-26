using Clinic_API.Models;
using ClinicQueriesAPI.Data;
using ClinicQueriesAPI.Entities;

namespace Clinic_API.Data
{
    public interface IUserRepository : IRepository
    {
        public User? ValidateUser(AuthenticationRequestBody requestBody);
    }
}
