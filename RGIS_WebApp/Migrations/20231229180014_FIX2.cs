using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGIS_WebApp.Migrations
{
    public partial class FIX2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatsDB");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UporabnikDB",
                table: "UporabnikDB");

            migrationBuilder.RenameColumn(
                name: "UporabnikId",
                table: "UporabnikDB",
                newName: "Wins");

            migrationBuilder.AlterColumn<int>(
                name: "Wins",
                table: "UporabnikDB",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UporabnikDB",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Assists",
                table: "UporabnikDB",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deaths",
                table: "UporabnikDB",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "KDR",
                table: "UporabnikDB",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Kills",
                table: "UporabnikDB",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Losses",
                table: "UporabnikDB",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Matches",
                table: "UporabnikDB",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UporabnikDB",
                table: "UporabnikDB",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UporabnikDB",
                table: "UporabnikDB");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UporabnikDB");

            migrationBuilder.DropColumn(
                name: "Assists",
                table: "UporabnikDB");

            migrationBuilder.DropColumn(
                name: "Deaths",
                table: "UporabnikDB");

            migrationBuilder.DropColumn(
                name: "KDR",
                table: "UporabnikDB");

            migrationBuilder.DropColumn(
                name: "Kills",
                table: "UporabnikDB");

            migrationBuilder.DropColumn(
                name: "Losses",
                table: "UporabnikDB");

            migrationBuilder.DropColumn(
                name: "Matches",
                table: "UporabnikDB");

            migrationBuilder.RenameColumn(
                name: "Wins",
                table: "UporabnikDB",
                newName: "UporabnikId");

            migrationBuilder.AlterColumn<int>(
                name: "UporabnikId",
                table: "UporabnikDB",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UporabnikDB",
                table: "UporabnikDB",
                column: "UporabnikId");

            migrationBuilder.CreateTable(
                name: "StatsDB",
                columns: table => new
                {
                    StatsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UporabnikId = table.Column<int>(type: "INTEGER", nullable: false),
                    Assists = table.Column<int>(type: "INTEGER", nullable: false),
                    Deaths = table.Column<int>(type: "INTEGER", nullable: false),
                    Kills = table.Column<int>(type: "INTEGER", nullable: false),
                    Loses = table.Column<int>(type: "INTEGER", nullable: false),
                    Matches = table.Column<int>(type: "INTEGER", nullable: false),
                    Wins = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatsDB", x => x.StatsId);
                    table.ForeignKey(
                        name: "FK_StatsDB_UporabnikDB_UporabnikId",
                        column: x => x.UporabnikId,
                        principalTable: "UporabnikDB",
                        principalColumn: "UporabnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StatsDB_UporabnikId",
                table: "StatsDB",
                column: "UporabnikId",
                unique: true);
        }
    }
}
