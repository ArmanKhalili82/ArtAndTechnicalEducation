using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtAndTechnicalEducationInstitute.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RejisterCource",
                table: "Students",
                newName: "RegisterCource");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RegisterCource",
                table: "Students",
                newName: "RejisterCource");
        }
    }
}
