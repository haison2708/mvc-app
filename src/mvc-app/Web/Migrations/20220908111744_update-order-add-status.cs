using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class updateorderaddstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductImage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 18, 17, 44, 295, DateTimeKind.Local).AddTicks(8357),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Product",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 18, 17, 44, 295, DateTimeKind.Local).AddTicks(7934),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderDetail",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 18, 17, 44, 295, DateTimeKind.Local).AddTicks(7422),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Order",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 18, 17, 44, 295, DateTimeKind.Local).AddTicks(6956),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Order",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 18, 17, 44, 295, DateTimeKind.Local).AddTicks(6515),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cart",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 18, 17, 44, 295, DateTimeKind.Local).AddTicks(6055),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(358));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Order");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductImage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(3847),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 18, 17, 44, 295, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Product",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(3114),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 18, 17, 44, 295, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderDetail",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(2358),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 18, 17, 44, 295, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Order",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(1560),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 18, 17, 44, 295, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(934),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 18, 17, 44, 295, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cart",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 17, 38, 33, 864, DateTimeKind.Local).AddTicks(358),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 8, 18, 17, 44, 295, DateTimeKind.Local).AddTicks(6055));
        }
    }
}
