using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Migrations
{
    public partial class LeaveRequest_edited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bda-4bb1-a6f7-f667e9095227",
                column: "ConcurrencyStamp",
                value: "51dd04f2-9c22-49c9-9d27-8a68c9df95d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                column: "ConcurrencyStamp",
                value: "e5df6606-a119-4fa3-a401-cc7c364be417");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a748593f-e0ee-49a1-9171-dc438410947c", "AQAAAAEAACcQAAAAEHw5pUOPLHh4J9bYLXkaOqm5f18z4+H3VshospzeqzLrggz0YZGlLtfYqXYveZu36Q==", "9a05e6b1-cad7-41be-a303-0c428088bdee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "465e702d-ebff-4b84-902d-66baaf73589d", "AQAAAAEAACcQAAAAELaYbRlrLizohZxhO3F4DOzGet7+nULys9m/2ybFvuk2BE3IU1qAPGmdS8TlPF84bQ==", "d065b137-1f3a-409c-a4c2-faff90417736" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
