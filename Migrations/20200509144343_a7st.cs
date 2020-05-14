using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobHub.Migrations
{
    public partial class a7st : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specializations",
                table: "Specializations");

            migrationBuilder.AddColumn<string>(
                name: "Specialization1",
                table: "Specializations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specialization2",
                table: "Specializations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specialization3",
                table: "Specializations",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GraduatedDate",
                table: "Educations",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specialization1",
                table: "Specializations");

            migrationBuilder.DropColumn(
                name: "Specialization2",
                table: "Specializations");

            migrationBuilder.DropColumn(
                name: "Specialization3",
                table: "Specializations");

            migrationBuilder.AddColumn<string>(
                name: "Specializations",
                table: "Specializations",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GraduatedDate",
                table: "Educations",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
