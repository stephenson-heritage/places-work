using Microsoft.EntityFrameworkCore.Migrations;

namespace places_work.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    PlaceID = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(7,5)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(8,5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.PlaceID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
