using Microsoft.EntityFrameworkCore.Migrations;

namespace YFinance.Data.Migrations
{
    public partial class AddPortfolioUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Portfolios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Portfolios");
        }
    }
}
