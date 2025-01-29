using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakalárska__práca.Migrations.Clinic
{
    /// <inheritdoc />
    public partial class addSpecialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "Dentists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "Dentists");
        }
    }
}
