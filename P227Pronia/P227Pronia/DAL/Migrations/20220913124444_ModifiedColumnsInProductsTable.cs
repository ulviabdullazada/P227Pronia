using Microsoft.EntityFrameworkCore.Migrations;

namespace P227Pronia.DAL.Migrations
{
    public partial class ModifiedColumnsInProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.AddColumn<decimal>(
                name: "CostPrice",
                table: "Products",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SellPrice",
                table: "Products",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "SoldCount",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SellPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SoldCount",
                table: "Products");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
