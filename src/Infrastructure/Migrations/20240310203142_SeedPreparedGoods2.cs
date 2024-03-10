using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DongPhuong.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedPreparedGoods2 : Migration
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
                    { 11, "grilled pork chop", "cơm suon nướng", 11.00m },
                    { 12, "grilled chicken", "cơm gà nướng", 11.00m },
                    { 13, "grilled pork", "cơm thịt nướng", 11.00m },
                    { 14, "grilled beef", "cơm bò nướng", 11.00m },
                    { 15, "grilled shrimp", "cơm tôm nướng", 13.00m },
                    { 16, "korean short ribs", "cơm sườn đại hàn", 13.00m },
                    { 17, "grilled tofu", "cơm đậu hủ nướng", 11.00m },
                    { 18, "pork chop & shredded pork skin", "cơm bì suon", 12.00m },
                    { 19, "grilled chicken vermicelli roll", "bánh hỏi gà nướng", 14.00m },
                    { 20, "grilled pork vermicelli roll", "bánh hỏi thịt nướng", 14.00m },
                    { 21, "grilled beef vermicelli roll", "bánh hỏi bò nướng", 14.00m },
                    { 22, "grilled shrimp vermicelli roll", "bánh hỏi tôm nướng", 15.00m },
                    { 23, "korean short ribs vermicelli roll", "bánh hỏi sườn đại hàn", 15.00m },
                    { 24, "viet sausage vermicelli roll", "bánh hỏi nem nướng", 12.50m },
                    { 25, "grilled tofu vermicelli roll", "bánh hỏi đậu hủ nướng", 12.50m },
                    { 26, "combination pho", "phở đặc biệt", 12.00m },
                    { 27, "brisket pho", "phở chin", 11.00m },
                    { 28, "eye of round pho", "phở tái", 11.00m },
                    { 29, "meatball pho", "phở bò viên", 11.00m },
                    { 30, "shrimp pho", "phở tôm", 13.00m },
                    { 31, "steamed veggies pho", "phở rau", 10.00m },
                    { 32, "broth & noodles pho", "phở nước lèo", 9.00m },
                    { 33, "any pho option", "kids phở", 5.00m },
                    { 34, "grilled chicken", "salad gà nướng", 10.00m },
                    { 35, "grilled pork", "salad thịt nướng", 10.00m },
                    { 36, "grilled beef", "salad bò nướng", 11.00m },
                    { 37, "grilled shrimp", "salad tôm nướng", 12.00m },
                    { 38, "egg roll (bún)", "salad chả giò", 10.00m },
                    { 39, "vietnamese sausage", "salad nem nướng", 11.00m },
                    { 40, "grilled tofu", "salad đậu hủ nướng", 10.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "Domain",
                table: "PreparedGoods",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
