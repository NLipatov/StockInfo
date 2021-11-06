using Microsoft.EntityFrameworkCore.Migrations;

namespace StockInfo.Migrations
{
    public partial class TestColumnDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "Stock");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "test",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
