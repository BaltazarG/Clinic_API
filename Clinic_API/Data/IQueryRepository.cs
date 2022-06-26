using ClinicQueriesAPI.Entities;

namespace ClinicQueriesAPI.Data
{
    public interface IQueryRepository : IRepository
    {
        public void AddQuery(int patientId, Query newQuery);
        Query? GetQuery(int patientId, int queryId);
        public IEnumerable<Query> GetQueries(int patientId);
        public void DeleteQuery(Query query);

        Query? GetQueryDoctor(int doctorId, int queryId);
        public IEnumerable<Query> GetQueriesDoctor(int doctorId);


    }
}
