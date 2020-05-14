using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobHub.Migrations
{
    public partial class okll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SavedOn",
                table: "Saves",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SavedOn",
                table: "Saves");
        }
    }
}
