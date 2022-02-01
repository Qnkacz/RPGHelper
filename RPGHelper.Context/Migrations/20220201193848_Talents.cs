using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGHelper.Context.Migrations
{
    public partial class Talents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talent_Career_CareerName",
                table: "Talent");

            migrationBuilder.DropForeignKey(
                name: "FK_Talent_PlayerCharacters_PlayerCharacterId",
                table: "Talent");

            migrationBuilder.DropForeignKey(
                name: "FK_Talent_Skill_SkillName",
                table: "Talent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Talent",
                table: "Talent");

            migrationBuilder.RenameTable(
                name: "Talent",
                newName: "Talents");

            migrationBuilder.RenameIndex(
                name: "IX_Talent_SkillName",
                table: "Talents",
                newName: "IX_Talents_SkillName");

            migrationBuilder.RenameIndex(
                name: "IX_Talent_PlayerCharacterId",
                table: "Talents",
                newName: "IX_Talents_PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Talent_CareerName",
                table: "Talents",
                newName: "IX_Talents_CareerName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Talents",
                table: "Talents",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Talents_Career_CareerName",
                table: "Talents",
                column: "CareerName",
                principalTable: "Career",
                principalColumn: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Talents_PlayerCharacters_PlayerCharacterId",
                table: "Talents",
                column: "PlayerCharacterId",
                principalTable: "PlayerCharacters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Talents_Skill_SkillName",
                table: "Talents",
                column: "SkillName",
                principalTable: "Skill",
                principalColumn: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talents_Career_CareerName",
                table: "Talents");

            migrationBuilder.DropForeignKey(
                name: "FK_Talents_PlayerCharacters_PlayerCharacterId",
                table: "Talents");

            migrationBuilder.DropForeignKey(
                name: "FK_Talents_Skill_SkillName",
                table: "Talents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Talents",
                table: "Talents");

            migrationBuilder.RenameTable(
                name: "Talents",
                newName: "Talent");

            migrationBuilder.RenameIndex(
                name: "IX_Talents_SkillName",
                table: "Talent",
                newName: "IX_Talent_SkillName");

            migrationBuilder.RenameIndex(
                name: "IX_Talents_PlayerCharacterId",
                table: "Talent",
                newName: "IX_Talent_PlayerCharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Talents_CareerName",
                table: "Talent",
                newName: "IX_Talent_CareerName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Talent",
                table: "Talent",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Talent_Career_CareerName",
                table: "Talent",
                column: "CareerName",
                principalTable: "Career",
                principalColumn: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Talent_PlayerCharacters_PlayerCharacterId",
                table: "Talent",
                column: "PlayerCharacterId",
                principalTable: "PlayerCharacters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Talent_Skill_SkillName",
                table: "Talent",
                column: "SkillName",
                principalTable: "Skill",
                principalColumn: "Name");
        }
    }
}
