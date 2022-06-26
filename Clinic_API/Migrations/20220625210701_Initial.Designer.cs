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
    [Migration("20220625210701_Initial")]
    partial class Initial
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

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 6,
                            Email = "nahuel@molina.com",
                            LastName = "Molina",
                            Name = "Nahuel",
                            Password = "123abcd"
                        },
                        new
                        {
                            Id = 7,
                            Email = "juan@perez.com",
                            LastName = "Perez",
                            Name = "Arturo",
                            Password = "123abv"
                        },
                        new
                        {
                            Id = 8,
                            Email = "julio@velez.com",
                            LastName = "Velez",
                            Name = "Julio",
                            Password = "123abcd"
                        });
                });

            modelBuilder.Entity("ClinicQueriesAPI.Entities.Patient", b =>
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

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "pablo@gomez.com",
                            LastName = "Gomez",
                            Name = "Pablo",
                            Password = "123abcd"
                        },
                        new
                        {
                            Id = 2,
                            Email = "juan@perez.com",
                            LastName = "Perez",
                            Name = "Juan",
                            Password = "123abv"
                        },
                        new
                        {
                            Id = 3,
                            Email = "bautista@velez.com",
                            LastName = "Velez",
                            Name = "Bautista",
                            Password = "123abcd"
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

                    b.HasIndex("PatientId");

                    b.ToTable("Queries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Dolor de pecho",
                            DoctorId = 6,
                            PatientId = 1,
                            StatusQuery = 0,
                            Title = "Cancer"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Picor en el cuello",
                            DoctorId = 6,
                            PatientId = 1,
                            StatusQuery = 0,
                            Title = "Dermatitis"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Resfrio y fiebre",
                            DoctorId = 7,
                            PatientId = 2,
                            StatusQuery = 0,
                            Title = "Gripe"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Perdida olfato",
                            DoctorId = 7,
                            PatientId = 2,
                            StatusQuery = 0,
                            Title = "Covid"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Resfrio y fiebre",
                            DoctorId = 8,
                            PatientId = 3,
                            StatusQuery = 0,
                            Title = "Gripe"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Resfrio y fiebre",
                            DoctorId = 8,
                            PatientId = 3,
                            StatusQuery = 0,
                            Title = "Gripe"
                        });
                });

            modelBuilder.Entity("ClinicQueriesAPI.Entities.Query", b =>
                {
                    b.HasOne("ClinicQueriesAPI.Entities.Patient", "Patient")
                        .WithMany("Queries")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ClinicQueriesAPI.Entities.Patient", b =>
                {
                    b.Navigation("Queries");
                });
#pragma warning restore 612, 618
        }
    }
}