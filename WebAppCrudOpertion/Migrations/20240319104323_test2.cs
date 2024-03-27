using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppCrudOpertion.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employees",
                newSchema: "HR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "HR",
                newName: "Employees");
        }
    }
}
