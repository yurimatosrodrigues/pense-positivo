using Microsoft.EntityFrameworkCore.Migrations;

namespace PensePositivoAPI.Migrations
{
    public partial class SizeColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Texts",
                type: "VARCHAR(110)",
                maxLength: 110,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Texts",
                type: "VARCHAR(550)",
                maxLength: 550,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Categories",
                type: "VARCHAR(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "VARCHAR(105)",
                maxLength: 105,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nacionality",
                table: "Authors",
                type: "VARCHAR(35)",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)",
                oldMaxLength: 30,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Texts",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(110)",
                oldMaxLength: 110,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Texts",
                type: "VARCHAR(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(550)",
                oldMaxLength: 550);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Categories",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(105)",
                oldMaxLength: 105,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nacionality",
                table: "Authors",
                type: "VARCHAR(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(35)",
                oldMaxLength: 35,
                oldNullable: true);
        }
    }
}
