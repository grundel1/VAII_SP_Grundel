using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakalárska_práca.Migrations
{
    /// <inheritdoc />
    public partial class addUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Zubari",
                table: "Zubari");

            migrationBuilder.RenameTable(
                name: "Zubari",
                newName: "Dentists");

            migrationBuilder.RenameColumn(
                name: "Priezvisko",
                table: "Dentists",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "Meno",
                table: "Dentists",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dentists",
                table: "Dentists",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dentists",
                table: "Dentists");

            migrationBuilder.RenameTable(
                name: "Dentists",
                newName: "Zubari");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Zubari",
                newName: "Priezvisko");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Zubari",
                newName: "Meno");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zubari",
                table: "Zubari",
                column: "Id");
        }
    }
}
