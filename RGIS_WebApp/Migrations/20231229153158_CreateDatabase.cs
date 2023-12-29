using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGIS_WebApp.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UporabnikDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Geslo = table.Column<string>(type: "TEXT", nullable: false),
                    IsPremium = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModerator = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UporabnikDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatsDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UporabnikId = table.Column<int>(type: "INTEGER", nullable: false),
                    Kills = table.Column<int>(type: "INTEGER", nullable: false),
                    Deaths = table.Column<int>(type: "INTEGER", nullable: false),
                    Assists = table.Column<int>(type: "INTEGER", nullable: false),
                    Wins = table.Column<int>(type: "INTEGER", nullable: false),
                    Loses = table.Column<int>(type: "INTEGER", nullable: false),
                    Matches = table.Column<int>(type: "INTEGER", nullable: false),
                    KDRatio = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatsDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatsDB_UporabnikDB_UporabnikId",
                        column: x => x.UporabnikId,
                        principalTable: "UporabnikDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StatsDB_UporabnikId",
                table: "StatsDB",
                column: "UporabnikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatsDB");

            migrationBuilder.DropTable(
                name: "UporabnikDB");
        }
    }
}
