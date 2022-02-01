﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPGHelper.Context.InfoTables.WarhammerFantasy;

#nullable disable

namespace RPGHelper.Context.Migrations
{
    [DbContext(typeof(WarhammerContext))]
    partial class WarhammerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("CareerCareer", b =>
                {
                    b.Property<string>("EntriesName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExitsName")
                        .HasColumnType("TEXT");

                    b.HasKey("EntriesName", "ExitsName");

                    b.HasIndex("ExitsName");

                    b.ToTable("CareerCareer");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.DataBase.Player", b =>
                {
                    b.Property<string>("PlayerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlayerTage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlayerName");

                    b.ToTable("PlayerList");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.CharacterStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AgId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BSId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FPId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FelId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IPId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IntId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MagId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SBId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TBId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WPId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WSId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AId");

                    b.HasIndex("AgId");

                    b.HasIndex("BSId");

                    b.HasIndex("FPId");

                    b.HasIndex("FelId");

                    b.HasIndex("IPId");

                    b.HasIndex("IntId");

                    b.HasIndex("MId");

                    b.HasIndex("MagId");

                    b.HasIndex("SBId");

                    b.HasIndex("SId");

                    b.HasIndex("TBId");

                    b.HasIndex("TId");

                    b.HasIndex("WId");

                    b.HasIndex("WPId");

                    b.HasIndex("WSId");

                    b.ToTable("CharacterStats");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrassPennies")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoldCrowns")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SilverShillings")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.MainStatComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdvanceValue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrentValue")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("StartValue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatTypeEnum")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MainStatComponent");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PersonalDetailsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Roll")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RollMax")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PersonalDetailsId");

                    b.ToTable("Mark");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.PersonalDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Birthplace")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EyeColor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HairColor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Height")
                        .HasColumnType("REAL");

                    b.Property<string>("StarSignName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SyblingCount")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("StarSignName");

                    b.ToTable("PersonalDetails");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.PlayerCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CareerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CharacterStatsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Experience")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PersonalDetailsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlayerName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Race")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CareerName");

                    b.HasIndex("CharacterStatsId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("PersonalDetailsId");

                    b.HasIndex("PlayerName");

                    b.ToTable("PlayerCharacters");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Skill", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("CareerName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Characteristic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdvanced")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlayerCharacterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.HasIndex("CareerName");

                    b.HasIndex("PlayerCharacterId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.StarSign", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("StarSign");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Talent", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("CareerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PlayerCharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SkillName")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.HasIndex("CareerName");

                    b.HasIndex("PlayerCharacterId");

                    b.HasIndex("SkillName");

                    b.ToTable("Talent");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Career", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdvanced")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("Career");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats.SecondaryStatComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdvanceValue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrentValue")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("StartValue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatTypeEnum")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SecondaryStatComponent");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Items.Item", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Availability")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Craftsmanship")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Encumbrance")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EquipmentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.HasIndex("EquipmentId");

                    b.ToTable("Item");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Item");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Items.WeaponDamage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Base")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRanged")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("WeaponDamage");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Items.WeaponQuality", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WeaponName")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.HasIndex("WeaponName");

                    b.ToTable("WeaponQuality");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Magic.Spell", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("CastingNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CastingTime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MagicType")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlayerCharacterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.HasIndex("IngredientName");

                    b.HasIndex("PlayerCharacterId");

                    b.ToTable("Spell");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.MainStatsBoost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CareerName")
                        .HasColumnType("TEXT");

                    b.Property<int>("PercentageAmount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeEnum")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CareerName");

                    b.ToTable("MainStatsBoost");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.SecondaryStatsBoost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BoostAmount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CareerName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TypeEnum")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CareerName");

                    b.ToTable("SecondaryStatsBoost");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Items.Weapon", b =>
                {
                    b.HasBaseType("RPGHelper.Models.Models.WarhammerFantasy.Items.Item");

                    b.Property<int>("DamageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Group")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlayerCharacterId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("DamageId");

                    b.HasIndex("PlayerCharacterId");

                    b.HasDiscriminator().HasValue("Weapon");
                });

            modelBuilder.Entity("CareerCareer", b =>
                {
                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Career", null)
                        .WithMany()
                        .HasForeignKey("EntriesName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Career", null)
                        .WithMany()
                        .HasForeignKey("ExitsName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.CharacterStats", b =>
                {
                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats.SecondaryStatComponent", "A")
                        .WithMany()
                        .HasForeignKey("AId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.MainStatComponent", "Ag")
                        .WithMany()
                        .HasForeignKey("AgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.MainStatComponent", "BS")
                        .WithMany()
                        .HasForeignKey("BSId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats.SecondaryStatComponent", "FP")
                        .WithMany()
                        .HasForeignKey("FPId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.MainStatComponent", "Fel")
                        .WithMany()
                        .HasForeignKey("FelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats.SecondaryStatComponent", "IP")
                        .WithMany()
                        .HasForeignKey("IPId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.MainStatComponent", "Int")
                        .WithMany()
                        .HasForeignKey("IntId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats.SecondaryStatComponent", "M")
                        .WithMany()
                        .HasForeignKey("MId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats.SecondaryStatComponent", "Mag")
                        .WithMany()
                        .HasForeignKey("MagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats.SecondaryStatComponent", "SB")
                        .WithMany()
                        .HasForeignKey("SBId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.MainStatComponent", "S")
                        .WithMany()
                        .HasForeignKey("SId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats.SecondaryStatComponent", "TB")
                        .WithMany()
                        .HasForeignKey("TBId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.MainStatComponent", "T")
                        .WithMany()
                        .HasForeignKey("TId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats.SecondaryStatComponent", "W")
                        .WithMany()
                        .HasForeignKey("WId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.MainStatComponent", "WP")
                        .WithMany()
                        .HasForeignKey("WPId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.MainStatComponent", "WS")
                        .WithMany()
                        .HasForeignKey("WSId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("A");

                    b.Navigation("Ag");

                    b.Navigation("BS");

                    b.Navigation("FP");

                    b.Navigation("Fel");

                    b.Navigation("IP");

                    b.Navigation("Int");

                    b.Navigation("M");

                    b.Navigation("Mag");

                    b.Navigation("S");

                    b.Navigation("SB");

                    b.Navigation("T");

                    b.Navigation("TB");

                    b.Navigation("W");

                    b.Navigation("WP");

                    b.Navigation("WS");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Mark", b =>
                {
                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.PersonalDetails", null)
                        .WithMany("Marks")
                        .HasForeignKey("PersonalDetailsId");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.PersonalDetails", b =>
                {
                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.StarSign", "StarSign")
                        .WithMany()
                        .HasForeignKey("StarSignName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StarSign");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.PlayerCharacter", b =>
                {
                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Career", "Career")
                        .WithMany()
                        .HasForeignKey("CareerName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.CharacterStats", "CharacterStats")
                        .WithMany()
                        .HasForeignKey("CharacterStatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.PersonalDetails", "PersonalDetails")
                        .WithMany()
                        .HasForeignKey("PersonalDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.DataBase.Player", null)
                        .WithMany("WarhammerCharacters")
                        .HasForeignKey("PlayerName");

                    b.Navigation("Career");

                    b.Navigation("CharacterStats");

                    b.Navigation("Equipment");

                    b.Navigation("PersonalDetails");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Skill", b =>
                {
                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Career", null)
                        .WithMany("AvailableSkills")
                        .HasForeignKey("CareerName");

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.PlayerCharacter", null)
                        .WithMany("KnownSkills")
                        .HasForeignKey("PlayerCharacterId");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Talent", b =>
                {
                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Career", null)
                        .WithMany("Talents")
                        .HasForeignKey("CareerName");

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.PlayerCharacter", null)
                        .WithMany("KnownTalents")
                        .HasForeignKey("PlayerCharacterId");

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.Skill", null)
                        .WithMany("RelatedTalents")
                        .HasForeignKey("SkillName");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Items.Item", b =>
                {
                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.Equipment", null)
                        .WithMany("Items")
                        .HasForeignKey("EquipmentId");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Items.WeaponQuality", b =>
                {
                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Items.Weapon", null)
                        .WithMany("Qualities")
                        .HasForeignKey("WeaponName");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Magic.Spell", b =>
                {
                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Items.Item", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.PlayerCharacter", null)
                        .WithMany("Spells")
                        .HasForeignKey("PlayerCharacterId");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.MainStatsBoost", b =>
                {
                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Career", null)
                        .WithMany("MainStatsBoosts")
                        .HasForeignKey("CareerName");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.SecondaryStatsBoost", b =>
                {
                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Career", null)
                        .WithMany("SecondaryStatsBoosts")
                        .HasForeignKey("CareerName");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Items.Weapon", b =>
                {
                    b.HasOne("RPGHelper.Models.Models.WarhammerFantasy.Items.WeaponDamage", "Damage")
                        .WithMany()
                        .HasForeignKey("DamageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.PlayerCharacter", null)
                        .WithMany("Weapons")
                        .HasForeignKey("PlayerCharacterId");

                    b.Navigation("Damage");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.DataBase.Player", b =>
                {
                    b.Navigation("WarhammerCharacters");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Equipment", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.PersonalDetails", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.PlayerCharacter", b =>
                {
                    b.Navigation("KnownSkills");

                    b.Navigation("KnownTalents");

                    b.Navigation("Spells");

                    b.Navigation("Weapons");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Skill", b =>
                {
                    b.Navigation("RelatedTalents");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Career", b =>
                {
                    b.Navigation("AvailableSkills");

                    b.Navigation("MainStatsBoosts");

                    b.Navigation("SecondaryStatsBoosts");

                    b.Navigation("Talents");
                });

            modelBuilder.Entity("RPGHelper.Models.Models.WarhammerFantasy.Items.Weapon", b =>
                {
                    b.Navigation("Qualities");
                });
#pragma warning restore 612, 618
        }
    }
}
