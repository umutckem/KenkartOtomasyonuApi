using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KenkartOtomasyonuApi.Migrations
{
    /// <inheritdoc />
    public partial class DataBaseV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilResmi",
                table: "kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilResmi",
                table: "kullanicilar");
        }
    }
}
