using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "310650e0-e769-4058-ae78-df28bb138df7",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5753a359-7fbe-45b3-837e-9ab3984c5e70", new DateOnly(1950, 12, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEIsI8jhtDbYEJE0Vxv4qoYWB/bzMO5ZBJ3VHukHImB+GCoGRagS7L22ydzv3nsRDDg==", "2864a033-454b-4881-9dc0-4f87345cad9b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "310650e0-e769-4058-ae78-df28bb138df7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2e198a7-fbd5-42a3-a185-ed7db750399f", "AQAAAAIAAYagAAAAEMQawZy9Q9lngH8KXPNvfwhoRDjqXG1KDcAvxa0FOhnpHN15KjlXfCELfNHFXl83gw==", "790805c9-cca0-4c71-beb7-5bb4ac98ff9a" });
        }
    }
}
