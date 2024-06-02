using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPSI3.Migrations
{
    /// <inheritdoc />
    public partial class PPSI40 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Trinkets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Boots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Trinkets");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Boots");
        }
    }
}
