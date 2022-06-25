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
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
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
                    Email = table.Column<string>(type: "TEXT", nullable: false)
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
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Queries_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[] { 6, "nahuel@molina.com", "Molina", "Nahuel", "123abcd" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[] { 7, "juan@perez.com", "Perez", "Arturo", "123abv" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[] { 8, "julio@velez.com", "Velez", "Julio", "123abcd" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[] { 1, "pablo@gomez.com", "Gomez", "Pablo", "123abcd" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[] { 2, "juan@perez.com", "Perez", "Juan", "123abv" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[] { 3, "bautista@velez.com", "Velez", "Bautista", "123abcd" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 1, null, "Dolor de pecho", 6, 1, null, 0, "Cancer" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 2, null, "Picor en el cuello", 6, 1, null, 0, "Dermatitis" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 3, null, "Resfrio y fiebre", 7, 2, null, 0, "Gripe" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 4, null, "Perdida olfato", 7, 2, null, 0, "Covid" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 5, null, "Resfrio y fiebre", 8, 3, null, 0, "Gripe" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 6, null, "Resfrio y fiebre", 8, 3, null, 0, "Gripe" });

            migrationBuilder.CreateIndex(
                name: "IX_Queries_PatientId",
                table: "Queries",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Queries");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
