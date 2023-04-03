using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Migrations
{
    public partial class LeaveRequest_table_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "06ce3a6a-5823-4759-a709-f47a0cf58a50");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "35528078-aa0d-4cd0-beb0-8bea184eedc3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f91608f-f700-40ce-a1af-5cfdeeb57478", "AQAAAAEAACcQAAAAEBLfGdTq6xhYR4U0Udz+19y2K6KoLNRN0GwV6ZtCr9GZYPithGYv+8i8rH+Fcaiqiw==", "5f71c7e3-e7c1-4883-92fe-5d9b32bf53a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8c88b3b-9acc-4651-95f5-0dd241f8d20a", "AQAAAAEAACcQAAAAECACj56CdTv+S57nZoE67yETAb+3oGFlDrCg2CbRKbreCOQ2aeo3jbpKAx/7cnyvOQ==", "cd549f27-e802-4625-9dad-4bbfe41a7254" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
