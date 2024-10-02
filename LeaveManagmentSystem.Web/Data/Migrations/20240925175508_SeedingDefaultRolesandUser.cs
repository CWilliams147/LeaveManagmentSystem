using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagmentSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "179aa034-fcd6-4d13-9433-67f0d73addaa", null, "Employee", "EMPLOYEE" },
                    { "a02a394e-b437-4b7d-8775-6c0362eb01bb", null, "Supervisor", "SUPERVISOR" },
                    { "34d4e67d-3091-4b12-9c27-2eac1d358d17", null, "Administrator", "ADMINISTRATOR" },
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "310650e0-e769-4058-ae78-df28bb138df7", 0, "d2e198a7-fbd5-42a3-a185-ed7db750399f", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMQawZy9Q9lngH8KXPNvfwhoRDjqXG1KDcAvxa0FOhnpHN15KjlXfCELfNHFXl83gw==", null, false, "790805c9-cca0-4c71-beb7-5bb4ac98ff9a", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "34d4e67d-3091-4b12-9c27-2eac1d358d17", "310650e0-e769-4058-ae78-df28bb138df7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "179aa034-fcd6-4d13-9433-67f0d73addaa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a02a394e-b437-4b7d-8775-6c0362eb01bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "34d4e67d-3091-4b12-9c27-2eac1d358d17", "310650e0-e769-4058-ae78-df28bb138df7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34d4e67d-3091-4b12-9c27-2eac1d358d17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "310650e0-e769-4058-ae78-df28bb138df7");
        }
    }
}
