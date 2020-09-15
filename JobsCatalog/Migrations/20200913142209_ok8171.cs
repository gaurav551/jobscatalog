using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsCatalog.Migrations
{
    public partial class ok8171 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppliedData",
                table: "AppliedJobs");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AppliedJobs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(256) CHARACTER SET utf8mb4",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AppliedDate",
                table: "AppliedJobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "JobPostedBy",
                table: "AppliedJobs",
                maxLength: 256,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppliedDate",
                table: "AppliedJobs");

            migrationBuilder.DropColumn(
                name: "JobPostedBy",
                table: "AppliedJobs");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AppliedJobs",
                type: "varchar(256) CHARACTER SET utf8mb4",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AppliedData",
                table: "AppliedJobs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
