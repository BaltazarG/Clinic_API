using AutoMapper;
using ClinicQueriesAPI.Data;
using ClinicQueriesAPI.Entities;
using ClinicQueriesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicQueriesAPI.Controllers
{
    [ApiController]
    [Route("api/patients/{patientId}/queries", Name = "GetQueries")]
    public class QueriesPatientController : ControllerBase
    {
        private readonly IQueryRepository _queryRepository;
        private readonly IMapper _mapper;
        public QueriesPatientController(IQueryRepository queryRepository, IMapper mapper)
        {
            _queryRepository = queryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<QueryDto>> GetQueries(int patientId)
        {
            if (!_queryRepository.IsPatient(patientId))
            {
                return NotFound();
            }

            List<Query>? queries = _queryRepository.GetQueries(patientId).ToList();


            return Ok(_mapper.Map<List<QueryDto>>(queries));
        }

        [HttpGet("{queryId}")]
        public ActionResult<QueryDto> GetQuery(int patientId, int queryId)
        {
            if (!_queryRepository.IsPatient(patientId))
            {
                return NotFound();
            }

            Query? query = _queryRepository.GetQuery(patientId, queryId);

            if (query is null)
                return NotFound();

            return Ok(_mapper.Map<QueryDto>(query));
        }

        [HttpPost]
        public ActionResult<QueryDto> CreateQuery(int patientId, QueryCreationDto queryToCreate)
        {
            if (!_queryRepository.IsPatient(patientId))
            {
                return NotFound();
            }


            Query newQuery = _mapper.Map<Query>(queryToCreate);

            _queryRepository.AddQuery(patientId, newQuery);
            _queryRepository.SaveChanges();

            return CreatedAtRoute("GetQueries",
                new
                {
                    patientId,
                    queryId = newQuery.Id
                },
                _mapper.Map<QueryDto>(newQuery));

        }

        [HttpPut("{queryId}")]
        public ActionResult<QueryDto> UpdateQuery(int patientId, int queryId, QueryUpdateDto queryUpdated)
        {
            if (!_queryRepository.IsPatient(patientId))
            {
                return NotFound();
            }

            var queryToUpdate = _queryRepository.GetQuery(patientId, queryId);
            if (queryToUpdate is null)
                return NotFound();


            _mapper.Map(queryUpdated, queryToUpdate);

            _queryRepository.SaveChanges();

            return NoContent();

        }

        [HttpDelete("{queryId}")]
        public ActionResult<QueryDto> DeleteQuery(int patientId, int queryId)
        {
            if (!_queryRepository.IsPatient(patientId))
            {
                return NotFound();
            }

            var queryToDelete = _queryRepository.GetQuery(patientId, queryId);
            if (queryToDelete is null)
                return NotFound();

            _queryRepository.DeleteQuery(queryToDelete);

            _queryRepository.SaveChanges();

            return NoContent();


        }
    }
}
