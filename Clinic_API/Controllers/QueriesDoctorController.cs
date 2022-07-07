using AutoMapper;
using ClinicQueriesAPI.Data;
using ClinicQueriesAPI.Entities;
using ClinicQueriesAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClinicQueriesAPI.Controllers
{
    [ApiController]
    [Route("api/doctors/{doctorId}/queries", Name = "GetQueriesDoctor")]
    [Authorize]

    public class QueriesDoctorController : ControllerBase
    {
        private readonly IQueryRepository _queryRepository;
        private readonly IMapper _mapper;
        public QueriesDoctorController(IQueryRepository queryRepository, IMapper mapper)
        {
            _queryRepository = queryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<QueryDto>> GetQueriesDoctor(int doctorId)
        {
            if (!_queryRepository.IsDoctor(doctorId))
            {
                return NotFound();
            }

            List<Query>? queries = _queryRepository.GetQueriesDoctor(doctorId).ToList();


            return Ok(_mapper.Map<List<QueryDto>>(queries));
        }

        [HttpGet("{queryId}")]
        public ActionResult<QueryDto> GetQueryDoctor(int doctorId, int queryId)
        {
            if (!_queryRepository.IsDoctor(doctorId))
            {
                return NotFound();
            }

            Query? query = _queryRepository.GetQueryDoctor(doctorId, queryId);

            if (query is null)
                return NotFound();

            return Ok(_mapper.Map<QueryDto>(query));
        }

        [HttpPut("{queryId}")]
        public ActionResult<QueryDto> UpdateQuery(int doctorId, int queryId, QueryUpdateDto queryUpdated)
        {
            if (!_queryRepository.IsDoctor(doctorId))
            {
                return NotFound();
            }

            var queryToUpdate = _queryRepository.GetQueryDoctor(doctorId, queryId);
            if (queryToUpdate is null)
                return NotFound();

            queryToUpdate.ResolvedAt = DateTime.Now;
            queryToUpdate.StatusQuery = Enums.StatusQuery.Resolved;

            _mapper.Map(queryUpdated, queryToUpdate);

            _queryRepository.SaveChanges();

            return NoContent();

        }

    }
}
