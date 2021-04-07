using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorShop.Server.Migrations
{
    public partial class ProductDateFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 8, 26, 34, 584, DateTimeKind.Local).AddTicks(3000), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 8, 26, 34, 586, DateTimeKind.Local).AddTicks(2544), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 8, 26, 34, 586, DateTimeKind.Local).AddTicks(2571), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 8, 26, 34, 586, DateTimeKind.Local).AddTicks(2578), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 8, 26, 34, 586, DateTimeKind.Local).AddTicks(2576), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 8, 26, 34, 586, DateTimeKind.Local).AddTicks(2581), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 7, 8, 26, 34, 586, DateTimeKind.Local).AddTicks(2583), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 6, 22, 42, 37, 364, DateTimeKind.Local).AddTicks(3077), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 6, 22, 42, 37, 366, DateTimeKind.Local).AddTicks(2358), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 6, 22, 42, 37, 366, DateTimeKind.Local).AddTicks(2386), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 6, 22, 42, 37, 366, DateTimeKind.Local).AddTicks(2393), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 6, 22, 42, 37, 366, DateTimeKind.Local).AddTicks(2390), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 6, 22, 42, 37, 366, DateTimeKind.Local).AddTicks(2395), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 4, 6, 22, 42, 37, 366, DateTimeKind.Local).AddTicks(2398), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
