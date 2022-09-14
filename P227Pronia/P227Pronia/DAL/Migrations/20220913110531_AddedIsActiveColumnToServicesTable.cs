using Microsoft.EntityFrameworkCore.Migrations;

namespace P227Pronia.DAL.Migrations
{
    public partial class AddedIsActiveColumnToServicesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Services",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Services");
        }
    }
}
