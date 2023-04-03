using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Migrations
{
    public partial class xxx1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "34f1971c-fdce-44e3-a154-4c8947f94e0b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "f82ff0a8-ee57-4a7f-8549-2d75c46e90b2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d0ac2325-40d6-4738-b7a2-cfaceb1fed34", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDJ89SBaZsI9OD1a0pHD5rpgSltQ9UnjAX+G9Do5qw9JJ43T39/621DBbZ8kCQb0WA==", "387e6483-4dfb-4e87-8baa-6b1491757f9d", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b609e8f5-1a9a-43e5-ac26-d6d8daed955b", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJKlbJAo7GeSD3efhRq8kNnFQrnC+Xzq+6aMJD6YE/VXjD3g0tWXBn+kM7oUGZ2jrQ==", "0fcb3c4a-87a4-49b9-b3c5-39b256303f23", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "fa108ee0-3b7b-4ad6-b155-89c6a3919e8a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "7d5f1d6c-0ee1-4764-9ce9-faef4dc2db35");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3d7fb91b-92a3-4af6-b493-4cf917ccb0c6", null, "AQAAAAEAACcQAAAAEKCcfw9MOmcH52QbJsJIN2zfDGAadKLh/NmqpUqkB1dVIVrcxayeDHOShjn8aSG69g==", "ea0d7acf-052f-42b0-8767-0e98b086c2e6", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9c52dbd0-46bb-4dfe-93bc-07161b29a9b8", null, "AQAAAAEAACcQAAAAECUcp6B8th67XcpqS1uAq28W/Xf8OLYsS+rU5nu+kL1r/uKCrVOcmM0RP6lXNNsMeA==", "a806a5b3-e40a-42fe-ab2b-31eb3d8ecd76", null });
        }
    }
}
