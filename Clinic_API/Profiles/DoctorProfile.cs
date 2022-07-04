using AutoMapper;
using Clinic_API.Models;
using ClinicQueriesAPI.Entities;
using ClinicQueriesAPI.Models;

namespace ClinicQueriesAPI.Profiles
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, DoctorDto>();
            CreateMap<Doctor, DoctorWithoutQueriesDto>();
            CreateMap<Doctor, DoctorPatientsDto>();
            CreateMap<Doctor, AuthDoctorDto>();
        }        
    }
}
