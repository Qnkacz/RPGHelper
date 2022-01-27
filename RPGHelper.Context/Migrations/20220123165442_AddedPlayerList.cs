using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGHelper.Context.Migrations
{
    public partial class AddedPlayerList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkillList",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsAdvanced = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Characteristic = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillList", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Talent",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    SkillName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talent", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Talent_SkillList_SkillName",
                        column: x => x.SkillName,
                        principalTable: "SkillList",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Talent_SkillName",
                table: "Talent",
                column: "SkillName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Talent");

            migrationBuilder.DropTable(
                name: "SkillList");
        }
    }
}
