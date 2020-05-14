using Microsoft.EntityFrameworkCore.Migrations;

namespace JobHub.Migrations
{
    public partial class a7s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MaritalStatus",
                table: "EmployeeProfiles",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(1) CHARACTER SET utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MaritalStatus",
                table: "EmployeeProfiles",
                type: "varchar(1) CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
