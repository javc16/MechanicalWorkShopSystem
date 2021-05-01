using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MechanicalWorkShopSystem.Migrations
{
    public partial class Adding_MasterProviderEntity_And_Relation_With_ProviderEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMasterProvider",
                table: "Provider",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MasterProviderId",
                table: "Provider",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MasterProvider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProvider = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterProvider", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Provider_MasterProviderId",
                table: "Provider",
                column: "MasterProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Provider_MasterProvider_MasterProviderId",
                table: "Provider",
                column: "MasterProviderId",
                principalTable: "MasterProvider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provider_MasterProvider_MasterProviderId",
                table: "Provider");

            migrationBuilder.DropTable(
                name: "MasterProvider");

            migrationBuilder.DropIndex(
                name: "IX_Provider_MasterProviderId",
                table: "Provider");

            migrationBuilder.DropColumn(
                name: "IdMasterProvider",
                table: "Provider");

            migrationBuilder.DropColumn(
                name: "MasterProviderId",
                table: "Provider");
        }
    }
}
