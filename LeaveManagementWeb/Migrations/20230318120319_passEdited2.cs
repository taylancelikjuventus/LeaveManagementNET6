using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Migrations
{
    public partial class passEdited2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "188450ca-f1d9-4889-ba45-8ed11187cfc6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "6485d087-20bc-400e-a6d2-b8e3cbd7b89b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7e2b8dc-e41c-4546-879d-015cdf5608b2", "AQAAAAEAACcQAAAAEDVTESnjWo+ZZD4lXElk92I+fVqDGEGxoWCYgbqTAbsg4CCG0spcO4GWMyYswpk+3g==", "0c62ddf8-9af3-4802-957e-18f17505990e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aacf401-1d74-4bbf-bc3e-1202c97cb777", "AQAAAAEAACcQAAAAEJk27tnwJgL0q6OEvhwD4xmo6kkciOldFl4aCd83dEKWL9GZ8DHbkef6PE8PjIYAlg==", "c6c3b50e-3f6c-40f1-b8d0-646173d01a32" });
        }
    }
}
