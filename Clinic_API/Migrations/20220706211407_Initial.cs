using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic_API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Specialty = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Queries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusQuery = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ResolvedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Diagnostic = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Queries_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Queries_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Specialty", "Token" },
                values: new object[] { 6, "kinesiologo@gmail.com", "Molina", "Nahuel", "1234567a", "Kinesiologo", null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Specialty", "Token" },
                values: new object[] { 7, "pediatra@gmail.com", "Perez", "Arturo", "1234567a", "Pediatra", null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Specialty", "Token" },
                values: new object[] { 8, "traumatologo@gmail.com", "Velez", "Julio", "1234567a", "Traumatologo", null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Specialty", "Token" },
                values: new object[] { 9, "cardiologo@gmail.com", "Moreno", "Alvaro", "1234567a", "Cardiologo", null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Specialty", "Token" },
                values: new object[] { 10, "dermatologo@gmail.com", "Torres", "Carlos", "1234567a", "Dermatologo", null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Specialty", "Token" },
                values: new object[] { 11, "oftalmologo@gmail.com", "Mendez", "Luis", "1234567a", "Oftalmologo", null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Specialty", "Token" },
                values: new object[] { 12, "ginecologo@gmail.com", "Lopez", "Pedro", "1234567a", "Ginecologo", null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Specialty", "Token" },
                values: new object[] { 13, "oncologo@gmail.com", "Villalba", "Leonel", "1234567a", "Oncologo", null });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Token" },
                values: new object[] { 1, "test@test.com", "Gomez", "Pablo", "1234567a", null });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Token" },
                values: new object[] { 2, "test2@test2.com", "Perez", "Juan", "1234567a", null });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Token" },
                values: new object[] { 3, "test3@test3.com", "Velez", "Bautista", "1234567a", null });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 1, new DateTime(2022, 7, 6, 18, 14, 6, 823, DateTimeKind.Local).AddTicks(3736), "Tengo mucha fiebre desde que tome sol", "Te vas a recuperar", 10, 1, new DateTime(2022, 7, 6, 18, 14, 6, 823, DateTimeKind.Local).AddTicks(3750), 1, "Fiebre" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 2, new DateTime(2022, 7, 6, 18, 14, 6, 823, DateTimeKind.Local).AddTicks(3753), "Picor en el cuello", null, 10, 1, null, 0, "Dermatitis" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 3, new DateTime(2022, 7, 6, 18, 14, 6, 823, DateTimeKind.Local).AddTicks(3754), "Me duele el pecho cuando camino 3 cuadras", null, 9, 1, null, 0, "Dolor de pecho" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 4, new DateTime(2022, 7, 6, 18, 14, 6, 823, DateTimeKind.Local).AddTicks(3756), "No llego a leer los subtitulos de una pelicula", null, 11, 1, null, 0, "Problemas de vista" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 5, new DateTime(2022, 7, 6, 18, 14, 6, 823, DateTimeKind.Local).AddTicks(3757), "Tengo poca energia y dolor en los pulmones", null, 13, 1, null, 0, "Posible cancer" });

            migrationBuilder.CreateIndex(
                name: "IX_Queries_DoctorId",
                table: "Queries",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Queries_PatientId",
                table: "Queries",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Queries");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
