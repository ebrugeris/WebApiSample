using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiSample.Migrations
{
    /// <inheritdoc />
    public partial class StudentTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UniversityId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_UniversityId",
                table: "Students",
                column: "UniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Universities_UniversityId",
                table: "Students",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Universities_UniversityId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_UniversityId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "Students");
        }
    }
}
