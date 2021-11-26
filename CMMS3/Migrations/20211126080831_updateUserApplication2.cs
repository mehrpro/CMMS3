using Microsoft.EntityFrameworkCore.Migrations;

namespace CMMS3.Migrations
{
    public partial class updateUserApplication2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyTitle", "CompnayIndex", "Description" },
                values: new object[] { 1, "PSG", (byte)1, "شرکت پدیده شیمی غرب" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyIdFk", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LimetedCompany", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cf4b710b-c1eb-4e89-b0f1-bd9e8c5a31dd", 0, 1, "24d3313e-8804-4acd-ba52-7ffe1a6e43ff", "fm708801@gmail.com", true, "Farshid", "Mohammadi", false, false, null, "FM708801@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAELYdrMvR/R78xxYSgTf2yTMjeAdCpCO+BiQTOmym/s4Ye75VuVYPm+YRIwzH2wyv0Q==", null, false, "c1e4e3cb-d92e-4a74-aa76-1f66fcd4c53f", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf4b710b-c1eb-4e89-b0f1-bd9e8c5a31dd");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
