using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductImage");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Cart");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductImage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 114, DateTimeKind.Local).AddTicks(2543),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 745, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Product",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 114, DateTimeKind.Local).AddTicks(1422),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 745, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderDetail",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 113, DateTimeKind.Local).AddTicks(9197),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 745, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Order",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 113, DateTimeKind.Local).AddTicks(7754),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 745, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 113, DateTimeKind.Local).AddTicks(7194),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 744, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Category",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CartItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 113, DateTimeKind.Local).AddTicks(4968),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 744, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cart",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 113, DateTimeKind.Local).AddTicks(2686),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 744, DateTimeKind.Local).AddTicks(6265));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Category");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductImage",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 745, DateTimeKind.Local).AddTicks(4256),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 114, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductImage",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Product",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 745, DateTimeKind.Local).AddTicks(3134),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 114, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Product",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderDetail",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 745, DateTimeKind.Local).AddTicks(1264),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 113, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "OrderDetail",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Order",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 745, DateTimeKind.Local).AddTicks(128),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 113, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Order",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 744, DateTimeKind.Local).AddTicks(9592),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 113, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Category",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CartItem",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 744, DateTimeKind.Local).AddTicks(7824),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 113, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "CartItem",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cart",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(2022, 8, 22, 21, 34, 19, 744, DateTimeKind.Local).AddTicks(6265),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 23, 21, 26, 15, 113, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Cart",
                type: "datetime",
                nullable: true);
        }
    }
}
