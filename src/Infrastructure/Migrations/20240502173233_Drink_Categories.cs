using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DongPhuong.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Drink_Categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                schema: "Domain",
                table: "Drinks",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                schema: "Domain",
                table: "Drinks");
        }
    }
}
