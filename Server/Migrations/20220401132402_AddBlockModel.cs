using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_SapirTeper_OfirEinhoren.Server.Migrations
{
    public partial class AddBlockModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectID = table.Column<int>(type: "INTEGER", nullable: false),
                    Rank = table.Column<int>(type: "INTEGER", nullable: false),
                    BlockType = table.Column<string>(type: "TEXT", nullable: true),
                    B_Text = table.Column<string>(type: "TEXT", nullable: true),
                    B_Image = table.Column<string>(type: "TEXT", nullable: true),
                    B_Title = table.Column<string>(type: "TEXT", nullable: true),
                    B_Subtitle = table.Column<string>(type: "TEXT", nullable: true),
                    B_ActionSelected = table.Column<string>(type: "TEXT", nullable: true),
                    B_UrlLink = table.Column<string>(type: "TEXT", nullable: true),
                    B_UrlText = table.Column<string>(type: "TEXT", nullable: true),
                    I_Type = table.Column<string>(type: "TEXT", nullable: true),
                    I_NumberOfAns = table.Column<int>(type: "INTEGER", nullable: false),
                    IQ_Text = table.Column<string>(type: "TEXT", nullable: true),
                    I_AnsOptions = table.Column<string>(type: "TEXT", nullable: true),
                    I_TrueAns = table.Column<string>(type: "TEXT", nullable: true),
                    I_FeedbackTrue = table.Column<string>(type: "TEXT", nullable: true),
                    I_FeedbackFalse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Blocks_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blocks_ProjectID",
                table: "Blocks",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blocks");
        }
    }
}
