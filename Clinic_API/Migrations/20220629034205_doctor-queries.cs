using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic_API.Migrations
{
    public partial class doctorqueries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 20, null, "Tengo mucha fiebre desde que tome sol", null, 10, 1, null, 0, "Fiebre" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 32, null, "Picor en el cuello", null, 10, 1, null, 0, "Dermatitis" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 41, null, "Me duele el pecho cuando camino 3 cuadras", null, 9, 1, null, 0, "Dolor de pecho" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 51, null, "No llego a leer los subtitulos de una pelicula", null, 11, 1, null, 0, "Problemas de vista" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 52, null, "Tengo poca energia y dolor en los pulmones", null, 13, 1, null, 0, "Posible cancer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 1, null, "Tengo mucha fiebre desde que tome sol", null, 10, 1, null, 0, "Fiebre" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 2, null, "Picor en el cuello", null, 10, 1, null, 0, "Dermatitis" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 3, null, "Me duele el pecho cuando camino 3 cuadras", null, 9, 1, null, 0, "Dolor de pecho" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 4, null, "No llego a leer los subtitulos de una pelicula", null, 11, 1, null, 0, "Problemas de vista" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 5, null, "Tengo poca energia y dolor en los pulmones", null, 13, 1, null, 0, "Posible cancer" });
        }
    }
}
