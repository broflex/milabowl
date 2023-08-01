using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Milabowl.Migrations
{
    /// <inheritdoc />
    public partial class AddMissingLineupInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bank",
                table: "Lineups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventTransferCost",
                table: "Lineups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventTransfers",
                table: "Lineups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OverallRank",
                table: "Lineups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Lineups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PointsOnBench",
                table: "Lineups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "Lineups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RankSort",
                table: "Lineups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPoints",
                table: "Lineups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Lineups",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bank",
                table: "Lineups");

            migrationBuilder.DropColumn(
                name: "EventTransferCost",
                table: "Lineups");

            migrationBuilder.DropColumn(
                name: "EventTransfers",
                table: "Lineups");

            migrationBuilder.DropColumn(
                name: "OverallRank",
                table: "Lineups");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Lineups");

            migrationBuilder.DropColumn(
                name: "PointsOnBench",
                table: "Lineups");

            migrationBuilder.DropColumn(
                name: "Rank",
                table: "Lineups");

            migrationBuilder.DropColumn(
                name: "RankSort",
                table: "Lineups");

            migrationBuilder.DropColumn(
                name: "TotalPoints",
                table: "Lineups");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Lineups");
        }
    }
}
