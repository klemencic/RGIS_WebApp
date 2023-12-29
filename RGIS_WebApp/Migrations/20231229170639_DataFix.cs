using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGIS_WebApp.Migrations
{
    public partial class DataFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StatsDB_UporabnikId",
                table: "StatsDB");

            migrationBuilder.DropColumn(
                name: "KDRatio",
                table: "StatsDB");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UporabnikDB",
                newName: "UporabnikId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StatsDB",
                newName: "StatsId");

            migrationBuilder.CreateIndex(
                name: "IX_StatsDB_UporabnikId",
                table: "StatsDB",
                column: "UporabnikId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StatsDB_UporabnikId",
                table: "StatsDB");

            migrationBuilder.RenameColumn(
                name: "UporabnikId",
                table: "UporabnikDB",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StatsId",
                table: "StatsDB",
                newName: "Id");

            migrationBuilder.AddColumn<double>(
                name: "KDRatio",
                table: "StatsDB",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_StatsDB_UporabnikId",
                table: "StatsDB",
                column: "UporabnikId");
        }
    }
}
