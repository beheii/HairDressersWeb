using Microsoft.EntityFrameworkCore.Migrations;

namespace HairDressersWeb.Migrations
{
    public partial class Seeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Customers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "MasterSurname", "Type" },
                values: new object[] { 5, "Hanyk", 0 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "MasterSurname", "Type" },
                values: new object[] { 1, "Vaskiv", 0 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "MasterSurname", "Type" },
                values: new object[] { 2, "Rudnyk", 0 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "MasterSurname", "Type" },
                values: new object[] { 3, "Dutka", 0 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "MasterSurname", "Type" },
                values: new object[] { 4, "Khalus", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Customers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
