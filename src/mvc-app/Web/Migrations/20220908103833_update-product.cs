using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class updateproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductImage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(3847),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 30, 21, 21, 47, 154, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Product",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(3114),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 30, 21, 21, 47, 154, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderDetail",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(2358),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 30, 21, 21, 47, 153, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Order",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(1560),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 30, 21, 21, 47, 153, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.AddColumn<int>(
                name: "Total",
                table: "Order",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(934),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 30, 21, 21, 47, 153, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cart",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(358),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 30, 21, 21, 47, 153, DateTimeKind.Local).AddTicks(8700));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Order");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductImage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 30, 21, 21, 47, 154, DateTimeKind.Local).AddTicks(737),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Product",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 30, 21, 21, 47, 154, DateTimeKind.Local).AddTicks(359),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderDetail",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 30, 21, 21, 47, 153, DateTimeKind.Local).AddTicks(9940),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Order",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 30, 21, 21, 47, 153, DateTimeKind.Local).AddTicks(9540),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 30, 21, 21, 47, 153, DateTimeKind.Local).AddTicks(9112),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cart",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 30, 21, 21, 47, 153, DateTimeKind.Local).AddTicks(8700),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(358));
        }
    }
}
