using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Migrations
{
    public partial class LeaveRequest_table_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
