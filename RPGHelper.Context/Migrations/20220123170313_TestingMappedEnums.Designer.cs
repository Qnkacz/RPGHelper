﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPGHelper.Context.InfoTables.WarhammerFantasy;

#nullable disable

namespace RPGHelper.Context.Migrations
{
    [DbContext(typeof(WarhammerContext))]
    [Migration("20220123170313_TestingMappedEnums")]
    partial class TestingMappedEnums
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Skill", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Characteristic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdvanced")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("SkillList");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Talent", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SkillName")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.HasIndex("SkillName");

                    b.ToTable("Talent");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Talent", b =>
                {
                    b.HasOne("RPGHelper.Context.Models.WarhammerFantasy.Character.Skill", null)
                        .WithMany("RelatedTalents")
                        .HasForeignKey("SkillName");
                });

            modelBuilder.Entity("RPGHelper.Context.Models.WarhammerFantasy.Character.Skill", b =>
                {
                    b.Navigation("RelatedTalents");
                });
#pragma warning restore 612, 618
        }
    }
}
