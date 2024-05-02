using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DongPhuong.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Categories_and_Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                schema: "Domain",
                table: "PreparedGoods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                schema: "Domain",
                table: "PreparedGoods");
        }
    }
}
