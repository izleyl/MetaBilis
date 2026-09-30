using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetaBiliş.Migrations
{
    /// <inheritdoc />
    public partial class EsnekTestYapisi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KullaniciCevaplari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KullaniciID = table.Column<int>(type: "INTEGER", nullable: false),
                    SoruId = table.Column<int>(type: "INTEGER", nullable: false),
                    VerilenCevap = table.Column<string>(type: "TEXT", nullable: false),
                    IsDogru = table.Column<bool>(type: "INTEGER", nullable: false),
                    EminlikPuani = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciCevaplari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sorular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TestId = table.Column<int>(type: "INTEGER", nullable: false),
                    SoruMetni = table.Column<string>(type: "TEXT", nullable: false),
                    SoruTipi = table.Column<string>(type: "TEXT", nullable: false),
                    DogruCevap = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sorular", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testler", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciCevaplari");

            migrationBuilder.DropTable(
                name: "Sorular");

            migrationBuilder.DropTable(
                name: "Testler");
        }
    }
}
