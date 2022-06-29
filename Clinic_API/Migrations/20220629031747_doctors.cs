using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic_API.Migrations
{
    public partial class doctors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "Password" },
                values: new object[] { "kinesiologo@gmail.com", "1234567a" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "Password" },
                values: new object[] { "pediatra@gmail.com", "1234567a" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "Password" },
                values: new object[] { "traumatologo@gmail.com", "1234567a" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Token" },
                values: new object[] { 9, "cardiologo@gmail.com", "Moreno", "Alvaro", "1234567a", null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Token" },
                values: new object[] { 10, "dermatologo@gmail.com", "Torres", "Carlos", "1234567a", null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Token" },
                values: new object[] { 11, "oftalmologo@gmail.com", "Mendez", "Luis", "1234567a", null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Token" },
                values: new object[] { 12, "ginecologo@gmail.com", "Lopez", "Pedro", "1234567a", null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password", "Token" },
                values: new object[] { 13, "oncologo@gmail.com", "Villalba", "Leonel", "1234567a", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Password" },
                values: new object[] { "test@test.com", "1234567a" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Password" },
                values: new object[] { "test2@test2.com", "1234567a" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Password" },
                values: new object[] { "test3@test3.com", "1234567a" });

            migrationBuilder.UpdateData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "DoctorId", "Title" },
                values: new object[] { "Tengo mucha fiebre desde que tome sol", 10, "Fiebre" });

            migrationBuilder.UpdateData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoctorId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DoctorId", "PatientId", "Title" },
                values: new object[] { "Me duele el pecho cuando camino 3 cuadras", 9, 1, "Dolor de pecho" });

            migrationBuilder.UpdateData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "DoctorId", "PatientId", "Title" },
                values: new object[] { "No llego a leer los subtitulos de una pelicula", 11, 1, "Problemas de vista" });

            migrationBuilder.UpdateData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "DoctorId", "PatientId", "Title" },
                values: new object[] { "Tengo poca energia y dolor en los pulmones", 13, 1, "Posible cancer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "Password" },
                values: new object[] { "nahuel@molina.com", "123abcd" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "Password" },
                values: new object[] { "juan@perez.com", "123abv" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "Password" },
                values: new object[] { "julio@velez.com", "123abcd" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Password" },
                values: new object[] { "pablo@gomez.com", "123abcd" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Password" },
                values: new object[] { "juan@perez.com", "123abv" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Password" },
                values: new object[] { "bautista@velez.com", "123abcd" });

            migrationBuilder.UpdateData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "DoctorId", "Title" },
                values: new object[] { "Dolor de pecho", 6, "Cancer" });

            migrationBuilder.UpdateData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 2,
                column: "DoctorId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DoctorId", "PatientId", "Title" },
                values: new object[] { "Resfrio y fiebre", 7, 2, "Gripe" });

            migrationBuilder.UpdateData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "DoctorId", "PatientId", "Title" },
                values: new object[] { "Perdida olfato", 7, 2, "Covid" });

            migrationBuilder.UpdateData(
                table: "Queries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "DoctorId", "PatientId", "Title" },
                values: new object[] { "Resfrio y fiebre", 8, 3, "Gripe" });

            migrationBuilder.InsertData(
                table: "Queries",
                columns: new[] { "Id", "CreatedAt", "Description", "Diagnostic", "DoctorId", "PatientId", "ResolvedAt", "StatusQuery", "Title" },
                values: new object[] { 6, null, "Resfrio y fiebre", null, 8, 3, null, 0, "Gripe" });
        }
    }
}
