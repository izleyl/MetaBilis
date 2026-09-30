using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetaBiliş.Migrations
{
    /// <inheritdoc />
    public partial class KullaniciTablosuGuncellemesi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "Kullanicilar",
                newName: "KullaniciAdi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KullaniciAdi",
                table: "Kullanicilar",
                newName: "Ad");
        }
    }
}
