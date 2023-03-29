using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Migrations
{
    public partial class myleave_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "d9012e1a-7b75-4cf6-84a6-20fe390d2bec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "f4c94275-e4a5-4391-bb1e-0580de049f76");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f624e10d-1320-45cf-b417-805b3337bbe9", "AQAAAAEAACcQAAAAEGaZPqhOuScw267AnUNIqsCRF56RUTDOIsqTDFm566KloNy5PiUpAXH9HIYARkW2HQ==", "37a5088e-13bf-4b76-b5b2-79e16e944c98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29c0acd9-fc3f-47d1-b499-324c685c6962", "AQAAAAEAACcQAAAAEG/fU8nQ28Zm4fzDocupJLMkQD/kBIDMPcH/5IDW/u5W0Yl0EL9kBoeIwnYA4OQIXA==", "e7ac839c-3e32-4fe3-9390-4e7e95552d53" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "774cd78c-c500-4670-8050-c557f02294ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "1604cff1-a443-4227-b7c7-fac997ae5cca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55cc3bf5-464b-41da-93c6-ec059efc03b4", "AQAAAAEAACcQAAAAEPkqZeaPrk7rety4YzaFm7ue21UWeMyAcFhW1uLjzt8+J50I+aGBHfYeCIf4oG49tw==", "25a48489-39c8-49ab-bb47-882e44f6396c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d678da7-07ad-4299-8088-34ac20c9bc16", "AQAAAAEAACcQAAAAEKVbYa6YOtddltRyCkE1zLBWIlC3kq986b784Bm8W8+H+7uOLArxLqzQixkmwqzRGA==", "4f9f9cec-56de-4163-8221-9dc09d2fa992" });
        }
    }
}
