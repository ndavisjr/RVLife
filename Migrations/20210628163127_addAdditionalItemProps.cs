using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RVLife.Migrations
{
    public partial class addAdditionalItemProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PurchasedFrom",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchasedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "PurchasedPrice",
                table: "Items",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchasedFrom",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "PurchasedOn",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "PurchasedPrice",
                table: "Items");
        }
    }
}
