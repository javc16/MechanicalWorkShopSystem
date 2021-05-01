using Microsoft.EntityFrameworkCore.Migrations;

namespace MechanicalWorkShopSystem.Migrations
{
    public partial class Adding_RecomandationEntity_And_Relation_With_ProviderEntity_And_UserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdRecomendation",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecomendationId",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdRecomendation",
                table: "Provider",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecomendationId",
                table: "Provider",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Recomendation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recomendation", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provider_Recomendation_RecomendationId",
                table: "Provider");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Recomendation_RecomendationId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Recomendation");

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
        }
    }
}
