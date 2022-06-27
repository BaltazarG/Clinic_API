using AutoMapper;
using Clinic_API.Models;
using ClinicQueriesAPI.Entities;
using ClinicQueriesAPI.Models;

namespace ClinicQueriesAPI.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient, PatientWithoutQueriesDto>();
            CreateMap<Patient, PatientDto>();
            CreateMap<PatientCreationDto, Patient>();
            CreateMap<PatientCreationDto, PatientWithoutQueriesDto>();
            CreateMap<PatientUpdateDto, Patient>();
            CreateMap<Patient, AuthPatientDto>();

        }
    }
}
