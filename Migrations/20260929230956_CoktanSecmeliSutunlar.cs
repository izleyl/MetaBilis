using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetaBiliş.Migrations
{
    /// <inheritdoc />
    public partial class CoktanSecmeliSutunlar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SecenekA",
                table: "Sorular",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecenekB",
                table: "Sorular",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecenekC",
                table: "Sorular",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecenekD",
                table: "Sorular",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecenekA",
                table: "Sorular");

            migrationBuilder.DropColumn(
                name: "SecenekB",
                table: "Sorular");

            migrationBuilder.DropColumn(
                name: "SecenekC",
                table: "Sorular");

            migrationBuilder.DropColumn(
                name: "SecenekD",
                table: "Sorular");
        }
    }
}
