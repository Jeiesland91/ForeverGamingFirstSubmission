﻿// <auto-generated />
using System;
using ForeverGaming.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ForeverGaming.Migrations
{
    [DbContext(typeof(GameContext))]
    [Migration("20210423195627_Initial Database Creation")]
    partial class InitialDatabaseCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ForeverGaming.Models.Format", b =>
                {
                    b.Property<string>("FormatId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("FormatId");

                    b.ToTable("Formats");

                    b.HasData(
                        new
                        {
                            FormatId = "ARCADE",
                            Name = "Arcade Game"
                        },
                        new
                        {
                            FormatId = "CONSOLE",
                            Name = "Gaming console"
                        },
                        new
                        {
                            FormatId = "MOBILE",
                            Name = "Mobile Device"
                        },
                        new
                        {
                            FormatId = "PC",
                            Name = "Personal Computer"
                        },
                        new
                        {
                            FormatId = "STREAMING",
                            Name = "Streaming"
                        },
                        new
                        {
                            FormatId = "TV",
                            Name = "Television"
                        },
                        new
                        {
                            FormatId = "VIRTUAL",
                            Name = "Virtual Reality"
                        },
                        new
                        {
                            FormatId = "WEB",
                            Name = "Web Browser"
                        });
                });

            modelBuilder.Entity("ForeverGaming.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FormatId")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("GameImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("TypeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("GameId");

                    b.HasIndex("FormatId");

                    b.HasIndex("GenreId");

                    b.HasIndex("TypeId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            FormatId = "PC",
                            GameImage = "doom.png",
                            GenreId = "FPS",
                            Name = "Doom",
                            TypeId = "FPS"
                        },
                        new
                        {
                            GameId = 2,
                            FormatId = "CONSOLE",
                            GameImage = "cod4.png",
                            GenreId = "FPS",
                            Name = "Call of Duty 4: Modern Warfare",
                            TypeId = "FPS"
                        },
                        new
                        {
                            GameId = 3,
                            FormatId = "CONSOLE",
                            GameImage = "wolfenstein.png",
                            GenreId = "FPS",
                            Name = "Wolfenstein: The New Order",
                            TypeId = "FPS"
                        },
                        new
                        {
                            GameId = 4,
                            FormatId = "PC",
                            GameImage = "overwatch.png",
                            GenreId = "FPS",
                            Name = "Overwatch",
                            TypeId = "FPS"
                        },
                        new
                        {
                            GameId = 5,
                            FormatId = "PC",
                            GameImage = "starcraft.png",
                            GenreId = "RTS",
                            Name = "StarCraft",
                            TypeId = "FPS"
                        },
                        new
                        {
                            GameId = 6,
                            FormatId = "CONSOLE",
                            GameImage = "agw.png",
                            GenreId = "RTS",
                            Name = "Age of Empires",
                            TypeId = "RTS"
                        },
                        new
                        {
                            GameId = 7,
                            FormatId = "CONSOLE",
                            GameImage = "ageII.png",
                            GenreId = "RTS",
                            Name = "Age of Empires II: Age of King",
                            TypeId = "RTS"
                        },
                        new
                        {
                            GameId = 8,
                            FormatId = "CONSOLE",
                            GameImage = "elder.png",
                            GenreId = "RPG",
                            Name = "The Elder Scrolls",
                            TypeId = "RTS"
                        },
                        new
                        {
                            GameId = 9,
                            FormatId = "CONSOLE",
                            GameImage = "assassin.png",
                            GenreId = "RPG",
                            Name = "Assassin's Creed",
                            TypeId = "STEALTH"
                        },
                        new
                        {
                            GameId = 10,
                            FormatId = "PC",
                            GameImage = "witcher3.png",
                            GenreId = "RPG",
                            Name = "The Witcher 3: Wild Hunt",
                            TypeId = "SRPG"
                        },
                        new
                        {
                            GameId = 11,
                            FormatId = "CONSOLE",
                            GameImage = "everquest.png",
                            GenreId = "MMORPG",
                            Name = "EverQuest",
                            TypeId = "SRPG"
                        },
                        new
                        {
                            GameId = 12,
                            FormatId = "PC",
                            GameImage = "wow.png",
                            GenreId = "MMORPG",
                            Name = "World of Warcraft",
                            TypeId = "SRPG"
                        },
                        new
                        {
                            GameId = 13,
                            FormatId = "PC",
                            GameImage = "starcraftlegacy.png",
                            GenreId = "MOBAs",
                            Name = "StarCraft: Legacy of the Void",
                            TypeId = "MOBA"
                        },
                        new
                        {
                            GameId = 14,
                            FormatId = "PC",
                            GameImage = "defense.png",
                            GenreId = "MOBAs",
                            Name = "Defense of the Ancients",
                            TypeId = "MOBA"
                        },
                        new
                        {
                            GameId = 15,
                            FormatId = "PC",
                            GameImage = "league",
                            GenreId = "MOBAs",
                            Name = "League of Legends",
                            TypeId = "MOBA"
                        },
                        new
                        {
                            GameId = 16,
                            FormatId = "CONSOLE",
                            GameImage = "smite.png",
                            GenreId = "MOBAs",
                            Name = "Smite",
                            TypeId = "MOBA"
                        },
                        new
                        {
                            GameId = 17,
                            FormatId = "PC",
                            GameImage = "heroes.png",
                            GenreId = "MOBAs",
                            Name = "Heroes of the Storm",
                            TypeId = "MOBA"
                        },
                        new
                        {
                            GameId = 18,
                            FormatId = "PC",
                            GameImage = "dota2.png",
                            GenreId = "MOBAs",
                            Name = "DOTA 2",
                            TypeId = "MOBA"
                        },
                        new
                        {
                            GameId = 19,
                            FormatId = "PC",
                            GameImage = "strife",
                            GenreId = "MOBAs",
                            Name = "Strife",
                            TypeId = "MOBA"
                        },
                        new
                        {
                            GameId = 20,
                            FormatId = "MOBILE",
                            GameImage = "vain.png",
                            GenreId = "MOBAs",
                            Name = "Vainglory",
                            TypeId = "MOBA"
                        },
                        new
                        {
                            GameId = 21,
                            FormatId = "PC",
                            GameImage = "arena.png",
                            GenreId = "MOBAs",
                            Name = "Arena of Valor",
                            TypeId = "MOBA"
                        },
                        new
                        {
                            GameId = 22,
                            FormatId = "MOBILE",
                            GameImage = "mobile.png",
                            GenreId = "MOBAs",
                            Name = "Mobile Legends",
                            TypeId = "MOBA"
                        },
                        new
                        {
                            GameId = 23,
                            FormatId = "PC",
                            GameImage = "battlerite.png",
                            GenreId = "MOBAs",
                            Name = "Battlerite",
                            TypeId = "MOBA"
                        },
                        new
                        {
                            GameId = 24,
                            FormatId = "PC",
                            GameImage = "heroesofnewerth.png",
                            GenreId = "MOBAs",
                            Name = "Heroes of Newerth",
                            TypeId = "MOBA"
                        },
                        new
                        {
                            GameId = 25,
                            FormatId = "CONSOLE",
                            GameImage = "maddennfl.png",
                            GenreId = "SPORT",
                            Name = "Madden NFL",
                            TypeId = "SPORT"
                        },
                        new
                        {
                            GameId = 26,
                            FormatId = "CONSOLE",
                            GameImage = "nbajam.png",
                            GenreId = "SPORT",
                            Name = "NBA Jam",
                            TypeId = "SPORT"
                        },
                        new
                        {
                            GameId = 27,
                            FormatId = "CONSOLE",
                            GameImage = "wiisports.png",
                            GenreId = "SPORT",
                            Name = "Wii Sports",
                            TypeId = "SPORT"
                        },
                        new
                        {
                            GameId = 28,
                            FormatId = "CONSOLE",
                            GameImage = "fifa20.png",
                            GenreId = "SPORT",
                            Name = "FIFA 20",
                            TypeId = "SPORT"
                        },
                        new
                        {
                            GameId = 29,
                            FormatId = "CONSOLE",
                            GameImage = "tonyhawk.png",
                            GenreId = "SPORT",
                            Name = "Tony Hawk's",
                            TypeId = "SPORT"
                        },
                        new
                        {
                            GameId = 30,
                            FormatId = "CONSOLE",
                            GameImage = "fightnight.png",
                            GenreId = "SPORT",
                            Name = "Fight Night Round 4",
                            TypeId = "CS"
                        },
                        new
                        {
                            GameId = 31,
                            FormatId = "CONSOLE",
                            GameImage = "mma.png",
                            GenreId = "SPORT",
                            Name = "EA Sports MMA",
                            TypeId = "CS"
                        },
                        new
                        {
                            GameId = 32,
                            FormatId = "CONSOLE",
                            GameImage = "upc.png",
                            GenreId = "SPORT",
                            Name = "UPC 2009 Undisputed",
                            TypeId = "CS"
                        },
                        new
                        {
                            GameId = 33,
                            FormatId = "CONSOLE",
                            GameImage = "fightnightchampion.png",
                            GenreId = "SPORT",
                            Name = "Fight Night Champion",
                            TypeId = "CS"
                        },
                        new
                        {
                            GameId = 34,
                            FormatId = "CONSOLE",
                            GameImage = "granturismo.png",
                            GenreId = "SPORT",
                            Name = "Gran Turismo Sport",
                            TypeId = "RACING"
                        },
                        new
                        {
                            GameId = 35,
                            FormatId = "CONSOLE",
                            GameImage = "crew.png",
                            GenreId = "SPORT",
                            Name = "The Crew",
                            TypeId = "RACING"
                        },
                        new
                        {
                            GameId = 36,
                            FormatId = "CONSOLE",
                            GameImage = "forza.png",
                            GenreId = "SPORT",
                            Name = "Forza Horizon 4",
                            TypeId = "RACING"
                        });
                });

            modelBuilder.Entity("ForeverGaming.Models.Genre", b =>
                {
                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = "FPS",
                            Name = "First-Person Shooter"
                        },
                        new
                        {
                            GenreId = "MMORPG",
                            Name = "Massively Multiplayer Online Role-Playing Game"
                        },
                        new
                        {
                            GenreId = "MOBAs",
                            Name = "Mobile Online Battle Area"
                        },
                        new
                        {
                            GenreId = "RPG",
                            Name = "Role-Playing Game"
                        },
                        new
                        {
                            GenreId = "RTS",
                            Name = "Real-Time Strategy"
                        },
                        new
                        {
                            GenreId = "SPORT",
                            Name = "Sports"
                        });
                });

            modelBuilder.Entity("ForeverGaming.Models.Type", b =>
                {
                    b.Property<string>("TypeId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("TypeId");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            TypeId = "CB",
                            Name = "City-Building"
                        },
                        new
                        {
                            TypeId = "CS",
                            Name = "Combat Sports"
                        },
                        new
                        {
                            TypeId = "ED",
                            Name = "Educational"
                        },
                        new
                        {
                            TypeId = "EX",
                            Name = "Exercise"
                        },
                        new
                        {
                            TypeId = "FIGHTING",
                            Name = "Fighting"
                        },
                        new
                        {
                            TypeId = "FPS",
                            Name = "First Person Shooter"
                        },
                        new
                        {
                            TypeId = "GS",
                            Name = "Grand Strategy"
                        },
                        new
                        {
                            TypeId = "IM",
                            Name = "Interactive Movie"
                        },
                        new
                        {
                            TypeId = "LS",
                            Name = "Life Sim"
                        },
                        new
                        {
                            TypeId = "MMORPG",
                            Name = "Massively Multiplayer Online Role-Playing Game"
                        },
                        new
                        {
                            TypeId = "MOBA",
                            Name = "Mobile Online Battle Area"
                        },
                        new
                        {
                            TypeId = "PG",
                            Name = "Party Games"
                        },
                        new
                        {
                            TypeId = "PF",
                            Name = "Platformer"
                        },
                        new
                        {
                            TypeId = "PUZZLE",
                            Name = "Puzzle"
                        },
                        new
                        {
                            TypeId = "RACING",
                            Name = "Racing"
                        },
                        new
                        {
                            TypeId = "RTS",
                            Name = "Real Time Strategy"
                        },
                        new
                        {
                            TypeId = "RHYTHM",
                            Name = "Rhythm"
                        },
                        new
                        {
                            TypeId = "RP",
                            Name = "Role-Play"
                        },
                        new
                        {
                            TypeId = "SRPG",
                            Name = "Sandbox RPGs"
                        },
                        new
                        {
                            TypeId = "SIM",
                            Name = "Simulation"
                        },
                        new
                        {
                            TypeId = "SPORT",
                            Name = "Sport Games"
                        },
                        new
                        {
                            TypeId = "STEALTH",
                            Name = "Stealth"
                        },
                        new
                        {
                            TypeId = "STRATEGY",
                            Name = "Strategy"
                        },
                        new
                        {
                            TypeId = "SURVIVAL",
                            Name = "Survival"
                        },
                        new
                        {
                            TypeId = "SH",
                            Name = "Survival Horror"
                        },
                        new
                        {
                            TypeId = "TFPS",
                            Name = "Tactical FPS"
                        },
                        new
                        {
                            TypeId = "TRP",
                            Name = "Tactical Role-Play"
                        },
                        new
                        {
                            TypeId = "TS",
                            Name = "Team Sports"
                        },
                        new
                        {
                            TypeId = "TEXT",
                            Name = "Text"
                        },
                        new
                        {
                            TypeId = "TD",
                            Name = "Tower Defense"
                        },
                        new
                        {
                            TypeId = "TRIVIA",
                            Name = "Trivia"
                        });
                });

            modelBuilder.Entity("ForeverGaming.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ForeverGaming.Models.Game", b =>
                {
                    b.HasOne("ForeverGaming.Models.Format", "Format")
                        .WithMany("Games")
                        .HasForeignKey("FormatId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ForeverGaming.Models.Genre", "Genre")
                        .WithMany("Games")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ForeverGaming.Models.Type", "Type")
                        .WithMany("Games")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
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
                    b.HasOne("ForeverGaming.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ForeverGaming.Models.User", null)
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

                    b.HasOne("ForeverGaming.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ForeverGaming.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}