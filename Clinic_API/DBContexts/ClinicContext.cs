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
                    Email="test@test.com",
                    Password="1234567a"

                    

                },
                new Patient()
                {
                    Id=2,
                    Name="Juan",
                    LastName="Perez",
                    Email="test2@test2.com",
                    Password="1234567a",
                   

                },
                new Patient()
                {
                    Id=3,
                    Name="Bautista",
                    LastName="Velez",
                    Email="test3@test3.com",
                    Password="1234567a",
                    
                }

            };
            modelBuilder.Entity<Patient>().HasData(patients);

            var doctors = new Doctor[8]
            {
                new Doctor()
                {
                    Id=6,
                    Name="Nahuel",
                    LastName="Molina",
                    Email="kinesiologo@gmail.com",
                    Password="1234567a",
                    Specialty="Kinesiologo"

                },
                new Doctor()
                {
                    Id=7,
                    Name="Arturo",
                    LastName="Perez",
                    Email="pediatra@gmail.com",
                    Password="1234567a",
                    Specialty="Pediatra"

                },
                new Doctor()
                {
                    Id=8,
                    Name="Julio",
                    LastName="Velez",
                    Email="traumatologo@gmail.com",
                    Password="1234567a",
                    Specialty="Traumatologo"
                },
                new Doctor()
                {
                    Id=9,
                    Name="Alvaro",
                    LastName="Moreno",
                    Email="cardiologo@gmail.com",
                    Password="1234567a",
                    Specialty="Cardiologo"
                },
                new Doctor()
                {
                    Id=10,
                    Name="Carlos",
                    LastName="Torres",
                    Email="dermatologo@gmail.com",
                    Password="1234567a",
                    Specialty="Dermatologo"
                },
                new Doctor()
                {
                    Id=11,
                    Name="Luis",
                    LastName="Mendez",
                    Email="oftalmologo@gmail.com",
                    Password="1234567a",
                    Specialty="Oftalmologo"
                },
                new Doctor()
                {
                    Id=12,
                    Name="Pedro",
                    LastName="Lopez",
                    Email="ginecologo@gmail.com",
                    Password="1234567a",
                    Specialty="Ginecologo"
                },
                new Doctor()
                {
                    Id=13,
                    Name="Leonel",
                    LastName="Villalba",
                    Email="oncologo@gmail.com",
                    Password="1234567a",
                    Specialty="Oncologo"
                }

            };
            modelBuilder.Entity<Doctor>().HasData(doctors);


            modelBuilder.Entity<Query>().HasData(
                new Query("Fiebre", "Tengo mucha fiebre desde que tome sol")
                {
                    Id = 1,
                    PatientId = patients[0].Id,
                    DoctorId = doctors[4].Id,
                    Diagnostic = "Te vas a recuperar",
                    CreatedAt = DateTime.Now,
                    StatusQuery = Enums.StatusQuery.Resolved,
                    ResolvedAt = DateTime.Now,

                },
                 new Query("Dermatitis", "Picor en el cuello")
                 {
                     Id = 2,
                     PatientId = patients[0].Id,
                     DoctorId = doctors[4].Id,
                     CreatedAt = DateTime.Now,
                     StatusQuery = Enums.StatusQuery.Pending

                 },
                new Query("Dolor de pecho", "Me duele el pecho cuando camino 3 cuadras")
                {
                    Id = 3,
                    PatientId = patients[0].Id,
                    DoctorId = doctors[3].Id,
                    CreatedAt = DateTime.Now,
                    StatusQuery = Enums.StatusQuery.Pending

                }
                ,
                new Query("Problemas de vista", "No llego a leer los subtitulos de una pelicula")
                {
                    Id = 4,
                    PatientId = patients[0].Id,
                    DoctorId = doctors[5].Id,
                    CreatedAt = DateTime.Now,
                    StatusQuery = Enums.StatusQuery.Pending

                }
                ,
                new Query("Posible cancer", "Tengo poca energia y dolor en los pulmones")
                {
                    Id = 5,
                    PatientId = patients[0].Id,
                    DoctorId = doctors[7].Id,
                    CreatedAt = DateTime.Now,
                    StatusQuery = Enums.StatusQuery.Pending

                }) ;

           


            base.OnModelCreating(modelBuilder);

        }
    }
}
