using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YFinance.Data.Migrations
{
    public partial class AddPortfolios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    PortfolioId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NetWorth = table.Column<string>(nullable: true),
                    DayGain = table.Column<string>(nullable: true),
                    DayGainPercent = table.Column<string>(nullable: true),
                    TotalGain = table.Column<string>(nullable: true),
                    TotalGainPercent = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.PortfolioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portfolios");
        }
    }
}
