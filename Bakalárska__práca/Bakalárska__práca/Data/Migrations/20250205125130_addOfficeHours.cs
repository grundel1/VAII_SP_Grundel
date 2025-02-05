using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakalárska__práca.Migrations
{
    /// <inheritdoc />
    public partial class addOfficeHours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "OfficeEndTime",
                table: "Dentists",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "OfficeStartTime",
                table: "Dentists",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfficeEndTime",
                table: "Dentists");

            migrationBuilder.DropColumn(
                name: "OfficeStartTime",
                table: "Dentists");
        }
    }
}
