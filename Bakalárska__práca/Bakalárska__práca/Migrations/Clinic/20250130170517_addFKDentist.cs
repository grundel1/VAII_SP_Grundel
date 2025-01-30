using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakalárska__práca.Migrations.Clinic
{
    /// <inheritdoc />
    public partial class addFKDentist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DentistId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DentistId",
                table: "Orders",
                column: "DentistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Dentists_DentistId",
                table: "Orders",
                column: "DentistId",
                principalTable: "Dentists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Dentists_DentistId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DentistId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DentistId",
                table: "Orders");
        }
    }
}
