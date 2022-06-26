using Clinic_API.Models;
using ClinicQueriesAPI.Data;
using ClinicQueriesAPI.DBContexts;
using ClinicQueriesAPI.Entities;

namespace Clinic_API.Data
{
    public class UserRepository : Repository, IUserRepository
    {
        public UserRepository(ClinicContext context) : base(context)
        {
        }

        public User? ValidateUser(AuthenticationRequestBody requestBody)
        {
            if(requestBody.UserType == "patient")
                return _context.Patients.FirstOrDefault(p => p.Email == requestBody.Email && p.Password == requestBody.Password);
            return _context.Doctors.FirstOrDefault(d => d.Email == requestBody.Email && d.Password == requestBody.Password);
        }
    }
}
