﻿// <auto-generated />
using System;
using ClinicQueriesAPI.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Clinic_API.Migrations
{
    [DbContext(typeof(ClinicContext))]
    [Migration("20220703155556_patients-doctor")]
    partial class patientsdoctor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("ClinicQueriesAPI.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 6,
                            Email = "kinesiologo@gmail.com",
                            LastName = "Molina",
                            Name = "Nahuel",
                            Password = "1234567a"
                        },
                        new
                        {
                            Id = 7,
                            Email = "pediatra@gmail.com",
                            LastName = "Perez",
                            Name = "Arturo",
                            Password = "1234567a"
                        },
                        new
                        {
                            Id = 8,
                            Email = "traumatologo@gmail.com",
                            LastName = "Velez",
                            Name = "Julio",
                            Password = "1234567a"
                        },
                        new
                        {
                            Id = 9,
                            Email = "cardiologo@gmail.com",
                            LastName = "Moreno",
                            Name = "Alvaro",
                            Password = "1234567a"
                        },
                        new
                        {
                            Id = 10,
                            Email = "dermatologo@gmail.com",
                            LastName = "Torres",
                            Name = "Carlos",
                            Password = "1234567a"
                        },
                        new
                        {
                            Id = 11,
                            Email = "oftalmologo@gmail.com",
                            LastName = "Mendez",
                            Name = "Luis",
                            Password = "1234567a"
                        },
                        new
                        {
                            Id = 12,
                            Email = "ginecologo@gmail.com",
                            LastName = "Lopez",
                            Name = "Pedro",
                            Password = "1234567a"
                        },
                        new
                        {
                            Id = 13,
                            Email = "oncologo@gmail.com",
                            LastName = "Villalba",
                            Name = "Leonel",
                            Password = "1234567a"
                        });
                });

            modelBuilder.Entity("ClinicQueriesAPI.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "test@test.com",
                            LastName = "Gomez",
                            Name = "Pablo",
                            Password = "1234567a"
                        },
                        new
                        {
                            Id = 2,
                            Email = "test2@test2.com",
                            LastName = "Perez",
                            Name = "Juan",
                            Password = "1234567a"
                        },
                        new
                        {
                            Id = 3,
                            Email = "test3@test3.com",
                            LastName = "Velez",
                            Name = "Bautista",
                            Password = "1234567a"
                        });
                });

            modelBuilder.Entity("ClinicQueriesAPI.Entities.Query", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Diagnostic")
                        .HasColumnType("TEXT");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ResolvedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusQuery")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Queries");

                    b.HasData(
                        new
                        {
                            Id = 20,
                            Description = "Tengo mucha fiebre desde que tome sol",
                            DoctorId = 10,
                            PatientId = 1,
                            StatusQuery = 0,
                            Title = "Fiebre"
                        },
                        new
                        {
                            Id = 32,
                            Description = "Picor en el cuello",
                            DoctorId = 10,
                            PatientId = 1,
                            StatusQuery = 0,
                            Title = "Dermatitis"
                        },
                        new
                        {
                            Id = 41,
                            Description = "Me duele el pecho cuando camino 3 cuadras",
                            DoctorId = 9,
                            PatientId = 1,
                            StatusQuery = 0,
                            Title = "Dolor de pecho"
                        },
                        new
                        {
                            Id = 51,
                            Description = "No llego a leer los subtitulos de una pelicula",
                            DoctorId = 11,
                            PatientId = 1,
                            StatusQuery = 0,
                            Title = "Problemas de vista"
                        },
                        new
                        {
                            Id = 52,
                            Description = "Tengo poca energia y dolor en los pulmones",
                            DoctorId = 13,
                            PatientId = 1,
                            StatusQuery = 0,
                            Title = "Posible cancer"
                        });
                });

            modelBuilder.Entity("ClinicQueriesAPI.Entities.Patient", b =>
                {
                    b.HasOne("ClinicQueriesAPI.Entities.Doctor", null)
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId");
                });

            modelBuilder.Entity("ClinicQueriesAPI.Entities.Query", b =>
                {
                    b.HasOne("ClinicQueriesAPI.Entities.Doctor", "Doctor")
                        .WithMany("Queries")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicQueriesAPI.Entities.Patient", "Patient")
                        .WithMany("Queries")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ClinicQueriesAPI.Entities.Doctor", b =>
                {
                    b.Navigation("Patients");

                    b.Navigation("Queries");
                });

            modelBuilder.Entity("ClinicQueriesAPI.Entities.Patient", b =>
                {
                    b.Navigation("Queries");
                });
#pragma warning restore 612, 618
        }
    }
}
