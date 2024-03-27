using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppCrudOpertion.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepatmentName",
                schema: "HR",
                table: "Departments",
                newName: "DepartmentName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                schema: "HR",
                table: "Departments",
                newName: "DepatmentName");
        }
    }
}
