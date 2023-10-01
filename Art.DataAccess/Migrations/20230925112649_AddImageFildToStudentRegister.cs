using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtAndTechnicalEducationInstitute.Migrations
{
    /// <inheritdoc />
    public partial class AddImageFildToStudentRegister : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Students");
        }
    }
}
