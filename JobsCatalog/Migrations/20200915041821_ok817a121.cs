using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsCatalog.Migrations
{
    public partial class ok817a121 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayOf",
                table: "EmployeeProfiles");

            migrationBuilder.DropColumn(
                name: "MonthOf",
                table: "EmployeeProfiles");

            migrationBuilder.DropColumn(
                name: "YearOf",
                table: "EmployeeProfiles");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "EmployeeProfiles",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(256) CHARACTER SET utf8mb4",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "EmployeeProfiles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9ef1fa72-8d04-40c2-b5d7-5b6bcd2d2859");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "88f9a26a-9c8e-4e70-9962-591c45f17dc8");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "EmployeeProfiles");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "EmployeeProfiles",
                type: "varchar(256) CHARACTER SET utf8mb4",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayOf",
                table: "EmployeeProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MonthOf",
                table: "EmployeeProfiles",
                type: "varchar(256) CHARACTER SET utf8mb4",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearOf",
                table: "EmployeeProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "54ab7d3e-0d79-4947-a1e3-e58b54d8e3ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c85e283a-827f-4186-bb9f-d7b122de68c5");
        }
    }
}
