﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PPSI.Nowy_folder;

#nullable disable

namespace PPSI3.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20240528124039_PPSI3.1")]
    partial class PPSI31
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PPSI.Nowy_folder.Champion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Champions");
                });

            modelBuilder.Entity("PPSI.Nowy_folder.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Slot1")
                        .HasColumnType("int");

                    b.Property<int>("Slot2")
                        .HasColumnType("int");

                    b.Property<int>("Slot3")
                        .HasColumnType("int");

                    b.Property<int>("Slot4")
                        .HasColumnType("int");

                    b.Property<int>("Slot5")
                        .HasColumnType("int");

                    b.Property<int>("Slot6")
                        .HasColumnType("int");

                    b.Property<int>("TrinketId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("PPSI.Nowy_folder.GameMode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MapId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamAmount")
                        .HasColumnType("int");

                    b.Property<int>("TeamSize")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GameModes");
                });

            modelBuilder.Entity("PPSI.Nowy_folder.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("PPSI.Nowy_folder.Map", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("PPSI.Nowy_folder.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameModeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("PPSI.Nowy_folder.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Asists")
                        .HasColumnType("int");

                    b.Property<int>("ChampionId")
                        .HasColumnType("int");

                    b.Property<int>("Cs")
                        .HasColumnType("int");

                    b.Property<int>("Deaths")
                        .HasColumnType("int");

                    b.Property<int>("Gold")
                        .HasColumnType("int");

                    b.Property<int>("Kills")
                        .HasColumnType("int");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("SummonerId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("PPSI.Nowy_folder.Summoner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Summoners");
                });

            modelBuilder.Entity("PPSI.Nowy_folder.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("PPSI3.Models.ChampionsAtribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AttackDamage")
                        .HasColumnType("bit");

                    b.Property<bool>("CanOneShot")
                        .HasColumnType("bit");

                    b.Property<int>("ChampionId")
                        .HasColumnType("int");

                    b.Property<bool>("Dash")
                        .HasColumnType("bit");

                    b.Property<bool>("HasCC")
                        .HasColumnType("bit");

                    b.Property<bool>("Heals")
                        .HasColumnType("bit");

                    b.Property<int>("IsGoodAgainstAttackDamage")
                        .HasColumnType("int");

                    b.Property<int>("IsGoodAgainstCC")
                        .HasColumnType("int");

                    b.Property<int>("IsGoodAgainstDash")
                        .HasColumnType("int");

                    b.Property<int>("IsGoodAgainstHeals")
                        .HasColumnType("int");

                    b.Property<int>("IsGoodAgainstLateGame")
                        .HasColumnType("int");

                    b.Property<int>("IsGoodAgainstMagicDamage")
                        .HasColumnType("int");

                    b.Property<int>("IsGoodAgainstOneShot")
                        .HasColumnType("int");

                    b.Property<int>("IsGoodAgainstPoke")
                        .HasColumnType("int");

                    b.Property<int>("IsGoodAgainstShield")
                        .HasColumnType("int");

                    b.Property<int>("IsGoodAgainstSquishy")
                        .HasColumnType("int");

                    b.Property<int>("IsGoodAgainstTanky")
                        .HasColumnType("int");

                    b.Property<bool>("LateGame")
                        .HasColumnType("bit");

                    b.Property<bool>("MagicDamage")
                        .HasColumnType("bit");

                    b.Property<bool>("Poke")
                        .HasColumnType("bit");

                    b.Property<bool>("Shield")
                        .HasColumnType("bit");

                    b.Property<bool>("Squishy")
                        .HasColumnType("bit");

                    b.Property<bool>("Tanky")
                        .HasColumnType("bit");

                    b.Property<int>("Winrate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ChampionsAtribute");
                });

            modelBuilder.Entity("PPSI3.Models.ChampionsRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Bot")
                        .HasColumnType("bit");

                    b.Property<bool>("Jungle")
                        .HasColumnType("bit");

                    b.Property<bool>("Mid")
                        .HasColumnType("bit");

                    b.Property<bool>("Supp")
                        .HasColumnType("bit");

                    b.Property<bool>("Top")
                        .HasColumnType("bit");

                    b.Property<int>("championId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ChampionsRole");
                });

            modelBuilder.Entity("PPSI3.Models.Trinket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trinkets");
                });
#pragma warning restore 612, 618
        }
    }
}
