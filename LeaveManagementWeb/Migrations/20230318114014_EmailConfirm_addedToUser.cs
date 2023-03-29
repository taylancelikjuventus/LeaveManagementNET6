using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Migrations
{
    public partial class EmailConfirm_addedToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "677a3c93-c788-43d0-b999-e7e902968935", true, "AQAAAAEAACcQAAAAEL0sIihi+tNOo28MtmcQ5DMhlrtOc/GyzV/aJd8aY1FaONRSMdEEMGKmFdkzNMLKCg==", "58b67a70-c29a-4fdc-840b-55cc39217d42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a3333b1-fa6e-42db-b1e3-570ac7fc3a82", true, "AQAAAAEAACcQAAAAEDSJ4l/33jI3Czf1ZbrxsWmfLq/Y4QJrkJoct+0bN+plbHf+yGbQ8wKSYqMAddAufA==", "55c16a83-755a-44bd-bfed-3c9b0bc09b88" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "c28bb95d-229a-466b-b148-915f398e36d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "a3d952cc-11ae-4e00-bfd8-d56a5192a7da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33a958d4-531c-4a27-950e-69cf2708ba7d", false, "AQAAAAEAACcQAAAAEPp8t5yWECOAUg6IT+2bnwdYW/+BjzQLG/aVDHmGeUXJ40VtXo4APKUs6vkdflTlPw==", "58feb68d-c7b2-4c2b-ad36-6303eec9bb2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b09619dc-be33-42e5-9c74-58cee0de3a30", false, "AQAAAAEAACcQAAAAEO115o2OvgFGs2kTFa4xgQB69ea/fVOLvkegtXUx5PQsWQwZC49fwGBrvSS0aJqWWQ==", "8c9620d2-a419-473e-b676-f5e5bbfc9ec6" });
        }
    }
}
