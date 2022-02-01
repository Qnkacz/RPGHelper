using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGHelper.Context.Migrations
{
    public partial class InitialContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Career",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsAdvanced = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Career", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GoldCrowns = table.Column<int>(type: "INTEGER", nullable: false),
                    SilverShillings = table.Column<int>(type: "INTEGER", nullable: false),
                    BrassPennies = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainStatComponent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    StatTypeEnum = table.Column<int>(type: "INTEGER", nullable: false),
                    StartValue = table.Column<int>(type: "INTEGER", nullable: false),
                    AdvanceValue = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentValue = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainStatComponent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryStatComponent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    StatTypeEnum = table.Column<int>(type: "INTEGER", nullable: false),
                    StartValue = table.Column<int>(type: "INTEGER", nullable: false),
                    AdvanceValue = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentValue = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryStatComponent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StarSign",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarSign", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "WeaponDamage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false),
                    IsRanged = table.Column<bool>(type: "INTEGER", nullable: false),
                    Base = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponDamage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CareerCareer",
                columns: table => new
                {
                    EntriesName = table.Column<string>(type: "TEXT", nullable: false),
                    ExitsName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerCareer", x => new { x.EntriesName, x.ExitsName });
                    table.ForeignKey(
                        name: "FK_CareerCareer_Career_EntriesName",
                        column: x => x.EntriesName,
                        principalTable: "Career",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CareerCareer_Career_ExitsName",
                        column: x => x.ExitsName,
                        principalTable: "Career",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MainStatsBoost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeEnum = table.Column<int>(type: "INTEGER", nullable: false),
                    PercentageAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    CareerName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainStatsBoost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainStatsBoost_Career_CareerName",
                        column: x => x.CareerName,
                        principalTable: "Career",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "SecondaryStatsBoost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeEnum = table.Column<int>(type: "INTEGER", nullable: false),
                    BoostAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    CareerName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryStatsBoost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecondaryStatsBoost_Career_CareerName",
                        column: x => x.CareerName,
                        principalTable: "Career",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "CharacterStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WSId = table.Column<int>(type: "INTEGER", nullable: false),
                    BSId = table.Column<int>(type: "INTEGER", nullable: false),
                    SId = table.Column<int>(type: "INTEGER", nullable: false),
                    TId = table.Column<int>(type: "INTEGER", nullable: false),
                    AgId = table.Column<int>(type: "INTEGER", nullable: false),
                    IntId = table.Column<int>(type: "INTEGER", nullable: false),
                    WPId = table.Column<int>(type: "INTEGER", nullable: false),
                    FelId = table.Column<int>(type: "INTEGER", nullable: false),
                    AId = table.Column<int>(type: "INTEGER", nullable: false),
                    WId = table.Column<int>(type: "INTEGER", nullable: false),
                    SBId = table.Column<int>(type: "INTEGER", nullable: false),
                    TBId = table.Column<int>(type: "INTEGER", nullable: false),
                    MId = table.Column<int>(type: "INTEGER", nullable: false),
                    MagId = table.Column<int>(type: "INTEGER", nullable: false),
                    IPId = table.Column<int>(type: "INTEGER", nullable: false),
                    FPId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterStats_MainStatComponent_AgId",
                        column: x => x.AgId,
                        principalTable: "MainStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_MainStatComponent_BSId",
                        column: x => x.BSId,
                        principalTable: "MainStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_MainStatComponent_FelId",
                        column: x => x.FelId,
                        principalTable: "MainStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_MainStatComponent_IntId",
                        column: x => x.IntId,
                        principalTable: "MainStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_MainStatComponent_SId",
                        column: x => x.SId,
                        principalTable: "MainStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_MainStatComponent_TId",
                        column: x => x.TId,
                        principalTable: "MainStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_MainStatComponent_WPId",
                        column: x => x.WPId,
                        principalTable: "MainStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_MainStatComponent_WSId",
                        column: x => x.WSId,
                        principalTable: "MainStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_SecondaryStatComponent_AId",
                        column: x => x.AId,
                        principalTable: "SecondaryStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_SecondaryStatComponent_FPId",
                        column: x => x.FPId,
                        principalTable: "SecondaryStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_SecondaryStatComponent_IPId",
                        column: x => x.IPId,
                        principalTable: "SecondaryStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_SecondaryStatComponent_MagId",
                        column: x => x.MagId,
                        principalTable: "SecondaryStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_SecondaryStatComponent_MId",
                        column: x => x.MId,
                        principalTable: "SecondaryStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_SecondaryStatComponent_SBId",
                        column: x => x.SBId,
                        principalTable: "SecondaryStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_SecondaryStatComponent_TBId",
                        column: x => x.TBId,
                        principalTable: "SecondaryStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_SecondaryStatComponent_WId",
                        column: x => x.WId,
                        principalTable: "SecondaryStatComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    EyeColor = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<float>(type: "REAL", nullable: false),
                    HairColor = table.Column<string>(type: "TEXT", nullable: false),
                    Height = table.Column<float>(type: "REAL", nullable: false),
                    StarSignName = table.Column<string>(type: "TEXT", nullable: false),
                    SyblingCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Birthplace = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalDetails_StarSign_StarSignName",
                        column: x => x.StarSignName,
                        principalTable: "StarSign",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mark",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Roll = table.Column<int>(type: "INTEGER", nullable: false),
                    RollMax = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PersonalDetailsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mark", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mark_PersonalDetails_PersonalDetailsId",
                        column: x => x.PersonalDetailsId,
                        principalTable: "PersonalDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlayerCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Race = table.Column<int>(type: "INTEGER", nullable: false),
                    CareerName = table.Column<string>(type: "TEXT", nullable: false),
                    PersonalDetailsId = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterStatsId = table.Column<int>(type: "INTEGER", nullable: false),
                    EquipmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Experience = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerCharacters_Career_CareerName",
                        column: x => x.CareerName,
                        principalTable: "Career",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerCharacters_CharacterStats_CharacterStatsId",
                        column: x => x.CharacterStatsId,
                        principalTable: "CharacterStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerCharacters_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerCharacters_PersonalDetails_PersonalDetailsId",
                        column: x => x.PersonalDetailsId,
                        principalTable: "PersonalDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Cost = table.Column<int>(type: "INTEGER", nullable: false),
                    Encumbrance = table.Column<int>(type: "INTEGER", nullable: false),
                    Availability = table.Column<int>(type: "INTEGER", nullable: false),
                    Craftsmanship = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    EquipmentId = table.Column<int>(type: "INTEGER", nullable: true),
                    Group = table.Column<int>(type: "INTEGER", nullable: true),
                    DamageId = table.Column<int>(type: "INTEGER", nullable: true),
                    PlayerCharacterId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Item_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_WeaponDamage_DamageId",
                        column: x => x.DamageId,
                        principalTable: "WeaponDamage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsAdvanced = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Characteristic = table.Column<int>(type: "INTEGER", nullable: false),
                    CareerName = table.Column<string>(type: "TEXT", nullable: true),
                    PlayerCharacterId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Skill_Career_CareerName",
                        column: x => x.CareerName,
                        principalTable: "Career",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Skill_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Spell",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    MagicType = table.Column<int>(type: "INTEGER", nullable: false),
                    CastingNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    CastingTime = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    IngredientName = table.Column<string>(type: "TEXT", nullable: false),
                    PlayerCharacterId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spell", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Spell_Item_IngredientName",
                        column: x => x.IngredientName,
                        principalTable: "Item",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spell_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WeaponQuality",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    WeaponName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponQuality", x => x.Name);
                    table.ForeignKey(
                        name: "FK_WeaponQuality_Item_WeaponName",
                        column: x => x.WeaponName,
                        principalTable: "Item",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "Talent",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CareerName = table.Column<string>(type: "TEXT", nullable: true),
                    PlayerCharacterId = table.Column<int>(type: "INTEGER", nullable: true),
                    SkillName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talent", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Talent_Career_CareerName",
                        column: x => x.CareerName,
                        principalTable: "Career",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Talent_PlayerCharacters_PlayerCharacterId",
                        column: x => x.PlayerCharacterId,
                        principalTable: "PlayerCharacters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Talent_Skill_SkillName",
                        column: x => x.SkillName,
                        principalTable: "Skill",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CareerCareer_ExitsName",
                table: "CareerCareer",
                column: "ExitsName");

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

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_WPId",
                table: "CharacterStats",
                column: "WPId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_WSId",
                table: "CharacterStats",
                column: "WSId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_DamageId",
                table: "Item",
                column: "DamageId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_EquipmentId",
                table: "Item",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PlayerCharacterId",
                table: "Item",
                column: "PlayerCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_MainStatsBoost_CareerName",
                table: "MainStatsBoost",
                column: "CareerName");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_PersonalDetailsId",
                table: "Mark",
                column: "PersonalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetails_StarSignName",
                table: "PersonalDetails",
                column: "StarSignName");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_CareerName",
                table: "PlayerCharacters",
                column: "CareerName");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_CharacterStatsId",
                table: "PlayerCharacters",
                column: "CharacterStatsId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_EquipmentId",
                table: "PlayerCharacters",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_PersonalDetailsId",
                table: "PlayerCharacters",
                column: "PersonalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondaryStatsBoost_CareerName",
                table: "SecondaryStatsBoost",
                column: "CareerName");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_CareerName",
                table: "Skill",
                column: "CareerName");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_PlayerCharacterId",
                table: "Skill",
                column: "PlayerCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Spell_IngredientName",
                table: "Spell",
                column: "IngredientName");

            migrationBuilder.CreateIndex(
                name: "IX_Spell_PlayerCharacterId",
                table: "Spell",
                column: "PlayerCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Talent_CareerName",
                table: "Talent",
                column: "CareerName");

            migrationBuilder.CreateIndex(
                name: "IX_Talent_PlayerCharacterId",
                table: "Talent",
                column: "PlayerCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Talent_SkillName",
                table: "Talent",
                column: "SkillName");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponQuality_WeaponName",
                table: "WeaponQuality",
                column: "WeaponName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareerCareer");

            migrationBuilder.DropTable(
                name: "MainStatsBoost");

            migrationBuilder.DropTable(
                name: "Mark");

            migrationBuilder.DropTable(
                name: "SecondaryStatsBoost");

            migrationBuilder.DropTable(
                name: "Spell");

            migrationBuilder.DropTable(
                name: "Talent");

            migrationBuilder.DropTable(
                name: "WeaponQuality");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "PlayerCharacters");

            migrationBuilder.DropTable(
                name: "WeaponDamage");

            migrationBuilder.DropTable(
                name: "Career");

            migrationBuilder.DropTable(
                name: "CharacterStats");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "PersonalDetails");

            migrationBuilder.DropTable(
                name: "MainStatComponent");

            migrationBuilder.DropTable(
                name: "SecondaryStatComponent");

            migrationBuilder.DropTable(
                name: "StarSign");
        }
    }
}
