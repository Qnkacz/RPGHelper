using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGHelper.Context.Migrations
{
    public partial class ChangedCharacterStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_MainStats_MainStatsId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_SecondaryStats_SecondaryStatsId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "BoxAmount",
                table: "SecondaryStatComponent");

            migrationBuilder.DropColumn(
                name: "BoxAmount",
                table: "MainStatComponent");

            migrationBuilder.RenameColumn(
                name: "SecondaryStatsId",
                table: "CharacterStats",
                newName: "WSId");

            migrationBuilder.RenameColumn(
                name: "MainStatsId",
                table: "CharacterStats",
                newName: "WPId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterStats_SecondaryStatsId",
                table: "CharacterStats",
                newName: "IX_CharacterStats_WSId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterStats_MainStatsId",
                table: "CharacterStats",
                newName: "IX_CharacterStats_WPId");

            migrationBuilder.AddColumn<int>(
                name: "AId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BSId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FPId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FelId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IPId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IntId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MagId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SBId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TBId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WId",
                table: "CharacterStats",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_AgId",
                table: "CharacterStats",
                column: "AgId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_AId",
                table: "CharacterStats",
                column: "AId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_BSId",
                table: "CharacterStats",
                column: "BSId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_FelId",
                table: "CharacterStats",
                column: "FelId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_FPId",
                table: "CharacterStats",
                column: "FPId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_IntId",
                table: "CharacterStats",
                column: "IntId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_IPId",
                table: "CharacterStats",
                column: "IPId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_MagId",
                table: "CharacterStats",
                column: "MagId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_MId",
                table: "CharacterStats",
                column: "MId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_SBId",
                table: "CharacterStats",
                column: "SBId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_SId",
                table: "CharacterStats",
                column: "SId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_TBId",
                table: "CharacterStats",
                column: "TBId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_TId",
                table: "CharacterStats",
                column: "TId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_WId",
                table: "CharacterStats",
                column: "WId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_MainStatComponent_AgId",
                table: "CharacterStats",
                column: "AgId",
                principalTable: "MainStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_MainStatComponent_BSId",
                table: "CharacterStats",
                column: "BSId",
                principalTable: "MainStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_MainStatComponent_FelId",
                table: "CharacterStats",
                column: "FelId",
                principalTable: "MainStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_MainStatComponent_IntId",
                table: "CharacterStats",
                column: "IntId",
                principalTable: "MainStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_MainStatComponent_SId",
                table: "CharacterStats",
                column: "SId",
                principalTable: "MainStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_MainStatComponent_TId",
                table: "CharacterStats",
                column: "TId",
                principalTable: "MainStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_MainStatComponent_WPId",
                table: "CharacterStats",
                column: "WPId",
                principalTable: "MainStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_MainStatComponent_WSId",
                table: "CharacterStats",
                column: "WSId",
                principalTable: "MainStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_AId",
                table: "CharacterStats",
                column: "AId",
                principalTable: "SecondaryStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_FPId",
                table: "CharacterStats",
                column: "FPId",
                principalTable: "SecondaryStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_IPId",
                table: "CharacterStats",
                column: "IPId",
                principalTable: "SecondaryStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_MagId",
                table: "CharacterStats",
                column: "MagId",
                principalTable: "SecondaryStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_MId",
                table: "CharacterStats",
                column: "MId",
                principalTable: "SecondaryStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_SBId",
                table: "CharacterStats",
                column: "SBId",
                principalTable: "SecondaryStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_TBId",
                table: "CharacterStats",
                column: "TBId",
                principalTable: "SecondaryStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_WId",
                table: "CharacterStats",
                column: "WId",
                principalTable: "SecondaryStatComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_MainStatComponent_AgId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_MainStatComponent_BSId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_MainStatComponent_FelId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_MainStatComponent_IntId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_MainStatComponent_SId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_MainStatComponent_TId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_MainStatComponent_WPId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_MainStatComponent_WSId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_AId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_FPId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_IPId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_MagId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_MId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_SBId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_TBId",
                table: "CharacterStats");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStats_SecondaryStatComponent_WId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_AgId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_AId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_BSId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_FelId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_FPId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_IntId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_IPId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_MagId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_MId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_SBId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_SId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_TBId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_TId",
                table: "CharacterStats");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStats_WId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "AId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "AgId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "BSId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "FPId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "FelId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "IPId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "IntId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "MId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "MagId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "SBId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "SId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "TBId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "TId",
                table: "CharacterStats");

            migrationBuilder.DropColumn(
                name: "WId",
                table: "CharacterStats");

            migrationBuilder.RenameColumn(
                name: "WSId",
                table: "CharacterStats",
                newName: "SecondaryStatsId");

            migrationBuilder.RenameColumn(
                name: "WPId",
                table: "CharacterStats",
                newName: "MainStatsId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterStats_WSId",
                table: "CharacterStats",
                newName: "IX_CharacterStats_SecondaryStatsId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterStats_WPId",
                table: "CharacterStats",
                newName: "IX_CharacterStats_MainStatsId");

            migrationBuilder.AddColumn<int>(
                name: "BoxAmount",
                table: "SecondaryStatComponent",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BoxAmount",
                table: "MainStatComponent",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_MainStats_MainStatsId",
                table: "CharacterStats",
                column: "MainStatsId",
                principalTable: "MainStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStats_SecondaryStats_SecondaryStatsId",
                table: "CharacterStats",
                column: "SecondaryStatsId",
                principalTable: "SecondaryStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
