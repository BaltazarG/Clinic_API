namespace ClinicQueriesAPI.Entities
{
    public class Doctor : User
    {
        public ICollection<Query> Queries { get; set; } = new List<Query>();
    }
}
