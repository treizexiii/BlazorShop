using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorShop.Server.Migrations
{
    public partial class EditionsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Editions_EditionId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_EditionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "EditionId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "EditionProduct",
                columns: table => new
                {
                    EditionsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditionProduct", x => new { x.EditionsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_EditionProduct_Editions_EditionsId",
                        column: x => x.EditionsId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditionProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EditionProduct_ProductsId",
                table: "EditionProduct",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditionProduct");

            migrationBuilder.AddColumn<int>(
                name: "EditionId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_EditionId",
                table: "Products",
                column: "EditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Editions_EditionId",
                table: "Products",
                column: "EditionId",
                principalTable: "Editions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
