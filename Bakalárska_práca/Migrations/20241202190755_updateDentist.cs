using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakalárska_práca.Migrations
{
    /// <inheritdoc />
    public partial class updateDentist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Dentists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Region",
                table: "Dentists");
        }
    }
}
