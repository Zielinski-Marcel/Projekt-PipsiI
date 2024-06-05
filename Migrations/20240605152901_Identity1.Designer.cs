﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PPSI3.Data;

#nullable disable

namespace PPSI3.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20240605152901_Identity1")]
    partial class Identity1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PPSI.Models.Champion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BackgrundPhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Champions");
                });

            modelBuilder.Entity("PPSI.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("PPSI.Models.Summoner", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("PPSI3.Models.Boot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Boots");
                });

            modelBuilder.Entity("PPSI3.Models.BootsAtribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AttackDamage")
                        .HasColumnType("bit");

                    b.Property<int>("BootsId")
                        .HasColumnType("int");

                    b.Property<bool>("CanOneShot")
                        .HasColumnType("bit");

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

                    b.HasKey("Id");

                    b.ToTable("BootsAtributes");
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

            modelBuilder.Entity("PPSI3.Models.ItemsAtribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AttackDamage")
                        .HasColumnType("bit");

                    b.Property<bool>("CanOneShot")
                        .HasColumnType("bit");

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

                    b.Property<int>("ItemId")
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

                    b.HasKey("Id");

                    b.ToTable("ItemsAtributes");
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

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trinkets");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PPSI.Models.Summoner", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PPSI.Models.Summoner", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PPSI.Models.Summoner", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PPSI.Models.Summoner", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
