using ClinicQueriesAPI.DBContexts;
using ClinicQueriesAPI.Entities;

namespace ClinicQueriesAPI.Data
{
    public class QueryRepository : Repository, IQueryRepository
    {

        public QueryRepository(ClinicContext context) : base(context)
        {

        }
        public void AddQuery(int patientId, Query newQuery)
        {
            var patient = _context.Patients.Where(p => p.Id == patientId).FirstOrDefault();


            newQuery.StatusQuery = Enums.StatusQuery.Pending;
            newQuery.CreatedAt = DateTime.Now;


            if (patient != null)
                patient.Queries.Add(newQuery);
      
        }

        public void DeleteQuery(Query query)
        {
            _context.Queries.Remove(query);
        }

        public IEnumerable<Query> GetQueries(int patientId)
        {
            return _context.Queries.Where(x => x.PatientId == patientId).ToList();
        }

        
        public Query? GetQuery(int patientId, int queryId)
        {
            return _context.Queries.Where(q => q.Id == queryId && q.PatientId == patientId).FirstOrDefault();
        }
        
        public IEnumerable<Query> GetQueriesDoctor(int doctorId)
        {
            return _context.Queries.Where(x => x.DoctorId == doctorId).ToList();
        }

        public Query? GetQueryDoctor(int doctorId, int queryId)
        {
            return _context.Queries.Where(q => q.Id == queryId && q.DoctorId == doctorId).FirstOrDefault();
        }
    }
}
