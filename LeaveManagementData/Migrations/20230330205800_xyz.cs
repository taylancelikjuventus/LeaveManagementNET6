using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Migrations
{
    public partial class xyz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "cf45b31d-13bc-48fa-bd0c-ae10de0624b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "afc1314e-f1b7-4f86-b3f5-8d66e1178c37");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01c4f053-0ec8-439f-bad3-55ee3b99026f", "AQAAAAEAACcQAAAAEGxAAcDszwFg5PRiSgrDrW2ry8iIP8dlU6jEYheoZW/du+hL4CBTqQugOkNveVmnLg==", "59487865-f7f3-4ec4-a09d-52b5c93c5b00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f36b6ae-a0d3-485e-bc51-ffa4ba0e04e1", "AQAAAAEAACcQAAAAEAY6uc0rPxv16BjLV2kQwrdUQkbMAPA551qrf+u9l/wjQ5oDO/6y8oK5kzkgvequPA==", "ae31d692-8472-40b9-8c1c-0cda8083cbd2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
