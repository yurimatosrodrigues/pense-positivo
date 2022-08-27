using Microsoft.EntityFrameworkCore.Migrations;

namespace PensePositivoAPI.Migrations
{
    public partial class AuthorIdNotRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Texts_Authors_AuthorId",
                table: "Texts");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Texts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Texts_Authors_AuthorId",
                table: "Texts",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Texts_Authors_AuthorId",
                table: "Texts");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Texts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Texts_Authors_AuthorId",
                table: "Texts",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
