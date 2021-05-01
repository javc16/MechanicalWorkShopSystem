using Microsoft.EntityFrameworkCore.Migrations;

namespace MechanicalWorkShopSystem.Migrations
{
    public partial class Modifying_relations_between_Provider_and_User_With_Recomendation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provider_Recomendation_RecomendationId",
                table: "Provider");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Recomendation_RecomendationId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RecomendationId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Provider_RecomendationId",
                table: "Provider");

            migrationBuilder.DropColumn(
                name: "IdRecomendation",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RecomendationId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IdRecomendation",
                table: "Provider");

            migrationBuilder.DropColumn(
                name: "RecomendationId",
                table: "Provider");

            migrationBuilder.AddColumn<int>(
                name: "IdProvider",
                table: "Recomendation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Recomendation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProviderId",
                table: "Recomendation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Recomendation",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recomendation_ProviderId",
                table: "Recomendation",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Recomendation_UserId",
                table: "Recomendation",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recomendation_Provider_ProviderId",
                table: "Recomendation",
                column: "ProviderId",
                principalTable: "Provider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recomendation_User_UserId",
                table: "Recomendation",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recomendation_Provider_ProviderId",
                table: "Recomendation");

            migrationBuilder.DropForeignKey(
                name: "FK_Recomendation_User_UserId",
                table: "Recomendation");

            migrationBuilder.DropIndex(
                name: "IX_Recomendation_ProviderId",
                table: "Recomendation");

            migrationBuilder.DropIndex(
                name: "IX_Recomendation_UserId",
                table: "Recomendation");

            migrationBuilder.DropColumn(
                name: "IdProvider",
                table: "Recomendation");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Recomendation");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "Recomendation");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Recomendation");

            migrationBuilder.AddColumn<int>(
                name: "IdRecomendation",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecomendationId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdRecomendation",
                table: "Provider",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecomendationId",
                table: "Provider",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_RecomendationId",
                table: "User",
                column: "RecomendationId");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_RecomendationId",
                table: "Provider",
                column: "RecomendationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Provider_Recomendation_RecomendationId",
                table: "Provider",
                column: "RecomendationId",
                principalTable: "Recomendation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Recomendation_RecomendationId",
                table: "User",
                column: "RecomendationId",
                principalTable: "Recomendation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
