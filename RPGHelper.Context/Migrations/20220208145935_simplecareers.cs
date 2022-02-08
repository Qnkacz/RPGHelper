using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGHelper.Context.Migrations
{
    public partial class simplecareers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CareerSimplifiedName",
                table: "SecondaryStatsBoost",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerSimplifiedName",
                table: "MainStatsBoost",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SimpleCareers",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsAdvanced = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AvailableSkills = table.Column<string>(type: "TEXT", nullable: false),
                    Talents = table.Column<string>(type: "TEXT", nullable: false),
                    Entries = table.Column<string>(type: "TEXT", nullable: false),
                    Exits = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleCareers", x => x.Name);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SecondaryStatsBoost_CareerSimplifiedName",
                table: "SecondaryStatsBoost",
                column: "CareerSimplifiedName");

            migrationBuilder.CreateIndex(
                name: "IX_MainStatsBoost_CareerSimplifiedName",
                table: "MainStatsBoost",
                column: "CareerSimplifiedName");

            migrationBuilder.AddForeignKey(
                name: "FK_MainStatsBoost_SimpleCareers_CareerSimplifiedName",
                table: "MainStatsBoost",
                column: "CareerSimplifiedName",
                principalTable: "SimpleCareers",
                principalColumn: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondaryStatsBoost_SimpleCareers_CareerSimplifiedName",
                table: "SecondaryStatsBoost",
                column: "CareerSimplifiedName",
                principalTable: "SimpleCareers",
                principalColumn: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainStatsBoost_SimpleCareers_CareerSimplifiedName",
                table: "MainStatsBoost");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondaryStatsBoost_SimpleCareers_CareerSimplifiedName",
                table: "SecondaryStatsBoost");

            migrationBuilder.DropTable(
                name: "SimpleCareers");

            migrationBuilder.DropIndex(
                name: "IX_SecondaryStatsBoost_CareerSimplifiedName",
                table: "SecondaryStatsBoost");

            migrationBuilder.DropIndex(
                name: "IX_MainStatsBoost_CareerSimplifiedName",
                table: "MainStatsBoost");

            migrationBuilder.DropColumn(
                name: "CareerSimplifiedName",
                table: "SecondaryStatsBoost");

            migrationBuilder.DropColumn(
                name: "CareerSimplifiedName",
                table: "MainStatsBoost");
        }
    }
}
