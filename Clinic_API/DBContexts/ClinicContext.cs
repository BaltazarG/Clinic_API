using ClinicQueriesAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClinicQueriesAPI.DBContexts
{
    public class ClinicContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Query> Queries { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var patients = new Patient[3]
            {
                new Patient()
                {
                    Id=1,
                    Name="Pablo",
                    LastName="Gomez",
                    Email="pablo@gomez.com",
                    Password="123abcd",
                    

                },
                new Patient()
                {
                    Id=2,
                    Name="Juan",
                    LastName="Perez",
                    Email="juan@perez.com",
                    Password="123abv",
                   

                },
                new Patient()
                {
                    Id=3,
                    Name="Bautista",
                    LastName="Velez",
                    Email="bautista@velez.com",
                    Password="123abcd",
                    
                }

            };
            modelBuilder.Entity<Patient>().HasData(patients);

            var doctors = new Doctor[3]
            {
                new Doctor()
                {
                    Id=6,
                    Name="Nahuel",
                    LastName="Molina",
                    Email="nahuel@molina.com",
                    Password="123abcd"

                },
                new Doctor()
                {
                    Id=7,
                    Name="Arturo",
                    LastName="Perez",
                    Email="juan@perez.com",
                    Password="123abv"

                },
                new Doctor()
                {
                    Id=8,
                    Name="Julio",
                    LastName="Velez",
                    Email="julio@velez.com",
                    Password="123abcd",
                }

            };
            modelBuilder.Entity<Doctor>().HasData(doctors);


            modelBuilder.Entity<Query>().HasData(
                new Query("Cancer", "Dolor de pecho")
                {
                    Id = 1,
                    PatientId = patients[0].Id,
                    DoctorId = doctors[0].Id

                },
                 new Query("Dermatitis", "Picor en el cuello")
                 {
                     Id = 2,
                     PatientId = patients[0].Id,
                     DoctorId = doctors[0].Id

                 },
                new Query("Gripe", "Resfrio y fiebre")
                {
                    Id = 3,
                    PatientId = patients[1].Id,
                    DoctorId = doctors[1].Id

                }
                ,
                new Query("Covid", "Perdida olfato")
                {
                    Id = 4,
                    PatientId = patients[1].Id,
                    DoctorId = doctors[1].Id

                }
                ,
                new Query("Gripe", "Resfrio y fiebre")
                {
                    Id = 5,
                    PatientId = patients[2].Id,
                    DoctorId = doctors[2].Id

                }
                ,
                new Query("Gripe", "Resfrio y fiebre")
                {
                    Id = 6,
                    PatientId = patients[2].Id,
                    DoctorId = doctors[2].Id

                });

            base.OnModelCreating(modelBuilder);

        }
    }
}
