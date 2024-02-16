using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DongPhuong.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PackagedGoodsInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Domain");

            migrationBuilder.CreateTable(
                name: "System.Linq.Enumerable+AppendPrepend1Iterator`1[System.Char]",
                schema: "Domain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(2,5)", precision: 2, scale: 5, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(2,10)", precision: 2, scale: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System.Linq.Enumerable+AppendPrepend1Iterator`1[System.Char]", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "System.Linq.Enumerable+AppendPrepend1Iterator`1[System.Char]",
                schema: "Domain");
        }
    }
}
