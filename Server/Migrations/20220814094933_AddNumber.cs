using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_SapirTeper_OfirEinhoren.Server.Migrations
{
    public partial class AddNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Blocks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Blocks");
        }
    }
}
