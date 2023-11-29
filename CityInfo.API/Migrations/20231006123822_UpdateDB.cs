using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityInfo.API.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointOfInterest_Cities_CityId",
                table: "PointOfInterest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointOfInterest",
                table: "PointOfInterest");

            migrationBuilder.RenameTable(
                name: "PointOfInterest",
                newName: "PointsOfInterest");

            migrationBuilder.RenameIndex(
                name: "IX_PointOfInterest_CityId",
                table: "PointsOfInterest",
                newName: "IX_PointsOfInterest_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointsOfInterest",
                table: "PointsOfInterest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfInterest_Cities_CityId",
                table: "PointsOfInterest",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfInterest_Cities_CityId",
                table: "PointsOfInterest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointsOfInterest",
                table: "PointsOfInterest");

            migrationBuilder.RenameTable(
                name: "PointsOfInterest",
                newName: "PointOfInterest");

            migrationBuilder.RenameIndex(
                name: "IX_PointsOfInterest_CityId",
                table: "PointOfInterest",
                newName: "IX_PointOfInterest_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointOfInterest",
                table: "PointOfInterest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PointOfInterest_Cities_CityId",
                table: "PointOfInterest",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
