using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGHelper.Context.Migrations
{
    public partial class AddedPlayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlayerName",
                table: "PlayerCharacters",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PlayerList",
                columns: table => new
                {
                    PlayerName = table.Column<string>(type: "TEXT", nullable: false),
                    PlayerTage = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerList", x => x.PlayerName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_PlayerName",
                table: "PlayerCharacters",
                column: "PlayerName");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerCharacters_PlayerList_PlayerName",
                table: "PlayerCharacters",
                column: "PlayerName",
                principalTable: "PlayerList",
                principalColumn: "PlayerName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCharacters_PlayerList_PlayerName",
                table: "PlayerCharacters");

            migrationBuilder.DropTable(
                name: "PlayerList");

            migrationBuilder.DropIndex(
                name: "IX_PlayerCharacters_PlayerName",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "PlayerName",
                table: "PlayerCharacters");
        }
    }
}
