﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Milabowl.Infrastructure.Contexts;

#nullable disable

namespace Milabowl.Migrations
{
    [DbContext(typeof(FantasyContext))]
    [Migration("20220804143001_RemoveHit")]
    partial class RemoveHit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Milabowl.Infrastructure.Models.Event", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("DataChecked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<int>("FantasyEventId")
                        .HasColumnType("int");

                    b.Property<bool>("Finished")
                        .HasColumnType("bit");

                    b.Property<int>("GameWeek")
                        .HasColumnType("int");

                    b.Property<int?>("MostCaptainedPlayerID")
                        .HasColumnType("int");

                    b.Property<int?>("MostSelectedPlayerID")
                        .HasColumnType("int");

                    b.Property<int?>("MostTransferredInPlayerID")
                        .HasColumnType("int");

                    b.Property<int?>("MostViceCaptainedPlayerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.League", b =>
                {
                    b.Property<Guid>("LeagueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AdminEntry")
                        .HasColumnType("int");

                    b.Property<bool>("Closed")
                        .HasColumnType("bit");

                    b.Property<string>("CodePrivacy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("FantasyLeagueId")
                        .HasColumnType("int");

                    b.Property<string>("LeagueType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scoring")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartEvent")
                        .HasColumnType("int");

                    b.HasKey("LeagueId");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.Lineup", b =>
                {
                    b.Property<Guid>("LineupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkEventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LineupId");

                    b.HasIndex("FkEventId");

                    b.HasIndex("FkUserId");

                    b.ToTable("Lineups");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.MilaGWScore", b =>
                {
                    b.Property<Guid>("MilaGWScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("BenchFail")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CapDef")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CapFail")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CapKeep")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("EqualStreak")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("GW")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GW69")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GWPosition")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GWPositionScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GWScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("GameWeek")
                        .HasColumnType("int");

                    b.Property<decimal>("HeadToHeadMeta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IncreaseStreak")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MilaPoints")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinusIsPlus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RedCard")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SixtyNineSub")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TrendyBitch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UniqueCap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("YellowCard")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MilaGWScoreId");

                    b.ToTable("MilaGWScores");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.MilaTotalScore", b =>
                {
                    b.Property<Guid>("MilaTotalScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("H2H")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MaxGWScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinGWScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NoHands")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TeamValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MilaTotalScoreId");

                    b.ToTable("MilaTotalScores");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.Player", b =>
                {
                    b.Property<Guid>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("Bonus")
                        .HasColumnType("int");

                    b.Property<int>("Bps")
                        .HasColumnType("int");

                    b.Property<int>("CleanSheets")
                        .HasColumnType("int");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Creativity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ElementType")
                        .HasColumnType("int");

                    b.Property<int>("EventPoints")
                        .HasColumnType("int");

                    b.Property<int>("FantasyPlayerId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FkTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Form")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GoalsConceded")
                        .HasColumnType("int");

                    b.Property<int>("GoalsScored")
                        .HasColumnType("int");

                    b.Property<bool>("InDreamteam")
                        .HasColumnType("bit");

                    b.Property<string>("Influence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Minutes")
                        .HasColumnType("int");

                    b.Property<string>("News")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NewsAdded")
                        .HasColumnType("datetime2");

                    b.Property<int>("NowCost")
                        .HasColumnType("int");

                    b.Property<int>("OwnGoals")
                        .HasColumnType("int");

                    b.Property<int>("PenaltiesMissed")
                        .HasColumnType("int");

                    b.Property<int>("PenaltiesSaved")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PointsPerGame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RedCards")
                        .HasColumnType("int");

                    b.Property<int>("Saves")
                        .HasColumnType("int");

                    b.Property<string>("SelectedByPercent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Special")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Threat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalPoints")
                        .HasColumnType("int");

                    b.Property<int>("TransfersIn")
                        .HasColumnType("int");

                    b.Property<int>("TransfersInEvent")
                        .HasColumnType("int");

                    b.Property<int>("TransfersOut")
                        .HasColumnType("int");

                    b.Property<int>("TransfersOutEvent")
                        .HasColumnType("int");

                    b.Property<string>("ValueForm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValueSeason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YellowCards")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("FkTeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.PlayerEvent", b =>
                {
                    b.Property<Guid>("PlayerEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("Bonus")
                        .HasColumnType("int");

                    b.Property<int>("Bps")
                        .HasColumnType("int");

                    b.Property<int>("CleanSheets")
                        .HasColumnType("int");

                    b.Property<string>("Creativity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FantasyPlayerEventId")
                        .HasColumnType("int");

                    b.Property<Guid>("FkEventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkPlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GoalsConceded")
                        .HasColumnType("int");

                    b.Property<int>("GoalsScored")
                        .HasColumnType("int");

                    b.Property<string>("IctIndex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InDreamteam")
                        .HasColumnType("bit");

                    b.Property<string>("Influence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Minutes")
                        .HasColumnType("int");

                    b.Property<int>("OwnGoals")
                        .HasColumnType("int");

                    b.Property<int>("PenaltiesMissed")
                        .HasColumnType("int");

                    b.Property<int>("PenaltiesSaved")
                        .HasColumnType("int");

                    b.Property<int>("RedCards")
                        .HasColumnType("int");

                    b.Property<int>("Saves")
                        .HasColumnType("int");

                    b.Property<int?>("Selected")
                        .HasColumnType("int");

                    b.Property<string>("Threat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalPoints")
                        .HasColumnType("int");

                    b.Property<int?>("TransferBalance")
                        .HasColumnType("int");

                    b.Property<int?>("TransfersIn")
                        .HasColumnType("int");

                    b.Property<int?>("TransfersOut")
                        .HasColumnType("int");

                    b.Property<decimal?>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("YellowCards")
                        .HasColumnType("int");

                    b.HasKey("PlayerEventId");

                    b.HasIndex("FkEventId");

                    b.HasIndex("FkPlayerId");

                    b.ToTable("PlayerEvents");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.PlayerEventLineup", b =>
                {
                    b.Property<Guid>("PlayerEventLineupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkLineupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkPlayerEventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCaptain")
                        .HasColumnType("bit");

                    b.Property<bool>("IsViceCaptain")
                        .HasColumnType("bit");

                    b.Property<int>("Multiplier")
                        .HasColumnType("int");

                    b.HasKey("PlayerEventLineupId");

                    b.HasIndex("FkLineupId");

                    b.HasIndex("FkPlayerEventId");

                    b.ToTable("PlayerEventLineups");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.Team", b =>
                {
                    b.Property<Guid>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FantasyTeamCode")
                        .HasColumnType("int");

                    b.Property<int>("FantasyTeamId")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventTotal")
                        .HasColumnType("int");

                    b.Property<int>("FantasyEntryId")
                        .HasColumnType("int");

                    b.Property<int>("FantasyResultId")
                        .HasColumnType("int");

                    b.Property<int>("LastRank")
                        .HasColumnType("int");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.UserHeadToHeadEvent", b =>
                {
                    b.Property<Guid>("UserHeadToHeadEventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Draw")
                        .HasColumnType("int");

                    b.Property<int>("FantasyUserHeadToHeadEventID")
                        .HasColumnType("int");

                    b.Property<Guid>("FkEventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsBye")
                        .HasColumnType("bit");

                    b.Property<bool>("IsKnockout")
                        .HasColumnType("bit");

                    b.Property<int>("LeagueID")
                        .HasColumnType("int");

                    b.Property<int>("Loss")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("Win")
                        .HasColumnType("int");

                    b.HasKey("UserHeadToHeadEventID");

                    b.HasIndex("FkEventId");

                    b.HasIndex("FkUserId");

                    b.ToTable("UserHeadToHeadEvents");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.UserLeague", b =>
                {
                    b.Property<Guid>("UserLeagueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkLeagueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserLeagueId");

                    b.HasIndex("FkLeagueId");

                    b.HasIndex("FkUserId");

                    b.ToTable("UserLeagues");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.Lineup", b =>
                {
                    b.HasOne("Milabowl.Infrastructure.Models.Event", "Event")
                        .WithMany("Lineups")
                        .HasForeignKey("FkEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Milabowl.Infrastructure.Models.User", "User")
                        .WithMany("Lineups")
                        .HasForeignKey("FkUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.Player", b =>
                {
                    b.HasOne("Milabowl.Infrastructure.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("FkTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.PlayerEvent", b =>
                {
                    b.HasOne("Milabowl.Infrastructure.Models.Event", "Event")
                        .WithMany("PlayerEvents")
                        .HasForeignKey("FkEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Milabowl.Infrastructure.Models.Player", "Player")
                        .WithMany("PlayerEvents")
                        .HasForeignKey("FkPlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.PlayerEventLineup", b =>
                {
                    b.HasOne("Milabowl.Infrastructure.Models.Lineup", "Lineup")
                        .WithMany("PlayerEventLineups")
                        .HasForeignKey("FkLineupId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Milabowl.Infrastructure.Models.PlayerEvent", "PlayerEvent")
                        .WithMany("PlayerEventLineups")
                        .HasForeignKey("FkPlayerEventId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Lineup");

                    b.Navigation("PlayerEvent");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.UserHeadToHeadEvent", b =>
                {
                    b.HasOne("Milabowl.Infrastructure.Models.Event", "Event")
                        .WithMany("PlayerHeadToHeadEvents")
                        .HasForeignKey("FkEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Milabowl.Infrastructure.Models.User", "User")
                        .WithMany("HeadToHeadEvents")
                        .HasForeignKey("FkUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.UserLeague", b =>
                {
                    b.HasOne("Milabowl.Infrastructure.Models.League", "League")
                        .WithMany("UserLeagues")
                        .HasForeignKey("FkLeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Milabowl.Infrastructure.Models.User", "User")
                        .WithMany("UserLeagues")
                        .HasForeignKey("FkUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("League");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.Event", b =>
                {
                    b.Navigation("Lineups");

                    b.Navigation("PlayerEvents");

                    b.Navigation("PlayerHeadToHeadEvents");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.League", b =>
                {
                    b.Navigation("UserLeagues");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.Lineup", b =>
                {
                    b.Navigation("PlayerEventLineups");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.Player", b =>
                {
                    b.Navigation("PlayerEvents");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.PlayerEvent", b =>
                {
                    b.Navigation("PlayerEventLineups");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.Team", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("Milabowl.Infrastructure.Models.User", b =>
                {
                    b.Navigation("HeadToHeadEvents");

                    b.Navigation("Lineups");

                    b.Navigation("UserLeagues");
                });
#pragma warning restore 612, 618
        }
    }
}
