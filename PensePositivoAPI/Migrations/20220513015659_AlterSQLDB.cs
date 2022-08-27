using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PensePositivoAPI.Migrations
{
    public partial class AlterSQLDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Texts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Authors",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Authors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
              name: "Name",
              table: "Authors",
              maxLength: 50,
              type: "VARCHAR",
              nullable: false);

            migrationBuilder.AlterColumn<string>(
             name: "Nacionality",
             table: "Authors",
             maxLength: 30,
             type: "VARCHAR",
             nullable: true);

            migrationBuilder.AlterColumn<string>(
            name: "Title",
            table: "Categories",
            maxLength: 50,
            type: "VARCHAR",
            nullable: false);

            migrationBuilder.AlterColumn<string>(
            name: "Description",
            table: "Categories",
            maxLength: 100,
            type: "VARCHAR",
            nullable: true);

            migrationBuilder.AlterColumn<string>(
            name: "Title",
            table: "Texts",
            maxLength: 100,
            type: "VARCHAR",
            nullable: false);

            migrationBuilder.AlterColumn<string>(
            name: "Description",
            table: "Texts",
            maxLength: 500,
            type: "VARCHAR",
            nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Texts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Authors",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Authors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
             name: "Name",
             table: "Authors",
             maxLength: 50,
             type: "VARCHAR",
             nullable: false);

            migrationBuilder.AlterColumn<string>(
             name: "Nacionality",
             table: "Authors",
             maxLength: 30,
             type: "VARCHAR",
             nullable: true);

            migrationBuilder.AlterColumn<string>(
            name: "Title",
            table: "Categories",
            maxLength: 50,
            type: "VARCHAR",
            nullable: false);

            migrationBuilder.AlterColumn<string>(
            name: "Description",
            table: "Categories",
            maxLength: 100,
            type: "VARCHAR",
            nullable: true);

            migrationBuilder.AlterColumn<string>(
            name: "Title",
            table: "Texts",
            maxLength: 100,
            type: "VARCHAR",
            nullable: false);

            migrationBuilder.AlterColumn<string>(
            name: "Description",
            table: "Texts",
            maxLength: 500,
            type: "VARCHAR",
            nullable: false);
        }
    }
}
