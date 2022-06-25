using AutoMapper;
using ClinicQueriesAPI.Entities;
using ClinicQueriesAPI.Models;

namespace ClinicQueriesAPI.Profiles
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, DoctorDto>();
        }        
    }
}
