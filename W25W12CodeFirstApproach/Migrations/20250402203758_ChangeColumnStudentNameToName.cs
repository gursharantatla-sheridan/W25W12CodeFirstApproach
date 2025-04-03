using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W25W12CodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnStudentNameToName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "StudentName");
        }
    }
}
