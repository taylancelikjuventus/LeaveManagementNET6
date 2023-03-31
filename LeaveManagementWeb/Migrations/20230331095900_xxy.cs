using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Migrations
{
    public partial class xxy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "045fad5b-91bb-4551-bab7-8e6281c3ceb0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "e98b2464-9733-45cf-bf90-590116f3b53e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "942b4660-722e-40a9-b69b-fe340ace6d9e", "AQAAAAEAACcQAAAAECk82byaUVVG65gzXXoAVqJhso0gtmHwtt12V2jHRRs9Qq2kEyHfZDJhP/EWkJcYdA==", "e5a5e459-0a26-4660-a64a-469cf609dc5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63e23241-9786-44fb-9fc8-138090792c5a", "AQAAAAEAACcQAAAAEFlHDMfje/bQT5NDKkcmQYpoZztxGmDGHsXTyHCj9GanMSarszhNsGMLtxmN13ogxg==", "dc51f618-a15c-43a2-a75a-71f4ded0b9c4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
