using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic_API.Migrations
{
    public partial class tokenDto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Patients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Doctors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Queries_DoctorId",
                table: "Queries",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Queries_Doctors_DoctorId",
                table: "Queries",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Queries_Doctors_DoctorId",
                table: "Queries");

            migrationBuilder.DropIndex(
                name: "IX_Queries_DoctorId",
                table: "Queries");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Doctors");
        }
    }
}
