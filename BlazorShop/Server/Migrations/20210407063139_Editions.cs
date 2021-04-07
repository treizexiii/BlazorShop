using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorShop.Server.Migrations
{
    public partial class Editions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EditionId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Editions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateCreated",
                value: new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateCreated",
                value: new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateCreated",
                value: new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Editions_EditionId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Editions");

            migrationBuilder.DropIndex(
                name: "IX_Products_EditionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "EditionId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 4, 7, 8, 26, 34, 584, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 4, 7, 8, 26, 34, 586, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2021, 4, 7, 8, 26, 34, 586, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2021, 4, 7, 8, 26, 34, 586, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateCreated",
                value: new DateTime(2021, 4, 7, 8, 26, 34, 586, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateCreated",
                value: new DateTime(2021, 4, 7, 8, 26, 34, 586, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateCreated",
                value: new DateTime(2021, 4, 7, 8, 26, 34, 586, DateTimeKind.Local).AddTicks(2583));
        }
    }
}
