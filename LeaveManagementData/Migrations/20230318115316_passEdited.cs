using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Migrations
{
    public partial class passEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "84f789b0-3174-40dd-bba1-a4a496ff5167");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "6dab0afe-9f18-4f02-8c7d-5287e2828ec6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "677a3c93-c788-43d0-b999-e7e902968935", "AQAAAAEAACcQAAAAEL0sIihi+tNOo28MtmcQ5DMhlrtOc/GyzV/aJd8aY1FaONRSMdEEMGKmFdkzNMLKCg==", "58b67a70-c29a-4fdc-840b-55cc39217d42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a3333b1-fa6e-42db-b1e3-570ac7fc3a82", "AQAAAAEAACcQAAAAEDSJ4l/33jI3Czf1ZbrxsWmfLq/Y4QJrkJoct+0bN+plbHf+yGbQ8wKSYqMAddAufA==", "55c16a83-755a-44bd-bfed-3c9b0bc09b88" });
        }
    }
}
