namespace ClinicQueriesAPI.Entities
{
    public class Patient : User
    {
        public ICollection<Query> Queries { get; set; } = new List<Query>();

    }
}
