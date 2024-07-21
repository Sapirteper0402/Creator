using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_SapirTeper_OfirEinhoren.Server.Migrations
{
    public partial class AddNewBlocksModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "B_ActionSelected",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "B_Image",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "B_Subtitle",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "B_Text",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "B_Title",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "B_UrlLink",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "B_UrlText",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "IQ_Text",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "I_AnsOptions",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "I_FeedbackFalse",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "I_FeedbackTrue",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "I_NumberOfAns",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "I_TrueAns",
                table: "Blocks");

            migrationBuilder.RenameColumn(
                name: "I_Type",
                table: "Blocks",
                newName: "BlockContent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlockContent",
                table: "Blocks",
                newName: "I_Type");

            migrationBuilder.AddColumn<string>(
                name: "B_ActionSelected",
                table: "Blocks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "B_Image",
                table: "Blocks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "B_Subtitle",
                table: "Blocks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "B_Text",
                table: "Blocks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "B_Title",
                table: "Blocks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "B_UrlLink",
                table: "Blocks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "B_UrlText",
                table: "Blocks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IQ_Text",
                table: "Blocks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_AnsOptions",
                table: "Blocks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_FeedbackFalse",
                table: "Blocks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "I_FeedbackTrue",
                table: "Blocks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "I_NumberOfAns",
                table: "Blocks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "I_TrueAns",
                table: "Blocks",
                type: "TEXT",
                nullable: true);
        }
    }
}
