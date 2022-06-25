using AutoMapper;
using ClinicQueriesAPI.Entities;
using ClinicQueriesAPI.Models;

namespace ClinicQueriesAPI.Profiles
{
    public class QueryProfile : Profile
    {
        public QueryProfile()
        {
            CreateMap<Query, QueryDto>();
            CreateMap<QueryDto, Query>();
            CreateMap<QueryCreationDto, Query>();
            CreateMap<QueryUpdateDto, Query>();
        }
    }
}
