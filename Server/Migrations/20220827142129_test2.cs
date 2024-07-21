using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_SapirTeper_OfirEinhoren.Server.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ToContinue",
                table: "Blocks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToContinue",
                table: "Blocks");
        }
    }
}
