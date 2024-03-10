using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DongPhuong.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedPreparedGoods1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Domain",
                table: "PreparedGoods",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "4 fried shrimp & pork egg rolls", "chả giò", 5.00m },
                    { 2, "2 shrimp & pork spring rolls", "gỏi cuốn", 5.00m },
                    { 3, "grilled chicken vermicelli", "bún gà nướng", 11.00m },
                    { 4, "grilled pork vermicelli", "bún thịt nướng", 11.00m },
                    { 5, "grilled beef vermicelli", "bún nướng", 11.00m },
                    { 6, "grilled shrimp vermicelli", "bún tôm nướng", 12.50m },
                    { 7, "egg roll vermicelli", "bún chả giò", 11.00m },
                    { 8, "lemon grass beef vermicelli", "bún bò xao", 12.50m },
                    { 9, "vietnamese sausage vermicelli", "bún nem nướng", 11.00m },
                    { 10, "grilled tofu vermicelli", "bún đậu hủ nướng", 9.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
