using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Migrations
{
    public partial class PeriodField_adddedToLeaveAllocationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "bcf3d104-61a6-4c5c-b0c9-da0d0945a43a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "78cc5fdc-fba7-4933-9dd1-581495fe2810");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ece3bd71-3c8c-4b65-b7f0-bf9c3d3ce1dc", "AQAAAAEAACcQAAAAEAj8Oi5m7YLpiqJwfucVajhKma8w4TfSHwf2jDJ8qN5fYi01rk5zIQYFSuvRvXoTgQ==", "81d06fdb-b5e5-427a-ac6b-6ea2916f38b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6f6213f-a2b2-441a-8166-86d6864d3c3d", "AQAAAAEAACcQAAAAEJmVB39K/p/rQIf9BeTD9pzuDQxzM0PB/6I3MLu6wVCVf9l9TieSmsYaiDnxwdDwYQ==", "8876f078-3113-43bc-9487-c5074bd9ad2a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0ac2325-40d6-4738-b7a2-cfaceb1fed34", "AQAAAAEAACcQAAAAEDJ89SBaZsI9OD1a0pHD5rpgSltQ9UnjAX+G9Do5qw9JJ43T39/621DBbZ8kCQb0WA==", "387e6483-4dfb-4e87-8baa-6b1491757f9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b609e8f5-1a9a-43e5-ac26-d6d8daed955b", "AQAAAAEAACcQAAAAEJKlbJAo7GeSD3efhRq8kNnFQrnC+Xzq+6aMJD6YE/VXjD3g0tWXBn+kM7oUGZ2jrQ==", "0fcb3c4a-87a4-49b9-b3c5-39b256303f23" });
        }
    }
}
