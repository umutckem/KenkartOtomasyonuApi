using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KenkartOtomasyonuApi.Migrations
{
    /// <inheritdoc />
    public partial class DataBaseV101 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Yetki",
                table: "kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Yetki",
                table: "kullanicilar");
        }
    }
}
