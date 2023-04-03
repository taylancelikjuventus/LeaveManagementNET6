using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Migrations
{
    public partial class xxx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d7fb91b-92a3-4af6-b493-4cf917ccb0c6", "AQAAAAEAACcQAAAAEKCcfw9MOmcH52QbJsJIN2zfDGAadKLh/NmqpUqkB1dVIVrcxayeDHOShjn8aSG69g==", "ea0d7acf-052f-42b0-8767-0e98b086c2e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c52dbd0-46bb-4dfe-93bc-07161b29a9b8", "AQAAAAEAACcQAAAAECUcp6B8th67XcpqS1uAq28W/Xf8OLYsS+rU5nu+kL1r/uKCrVOcmM0RP6lXNNsMeA==", "a806a5b3-e40a-42fe-ab2b-31eb3d8ecd76" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "5b4a95bf-b3c9-4cc0-9571-909285c223d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "2a0e0af4-8dc9-4cc9-b753-23d4e3b4812c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10d01cc2-17d9-4831-a038-50ad9cd9002b", "AQAAAAEAACcQAAAAEFA5GVJrftFVP6mlKSFpnZ/l0xTE8M3OrVC/NjIzuNZeYzVjmt96s7DgQD0CBczcPQ==", "ac815cea-f966-4936-93f2-1c7d7358d572" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fd763d9-d53e-4c3b-8f05-5372ddee32ed", "AQAAAAEAACcQAAAAEEZ4fbDoufVDAf09AISxoSct2tdaXxmIVNYmGSWUbsHXm2SZgQ9dCX0/pUyqenE6yQ==", "5492cd70-6b9c-4630-97df-b8315e1bfd26" });
        }
    }
}
