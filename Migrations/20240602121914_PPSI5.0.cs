using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPSI3.Migrations
{
    /// <inheritdoc />
    public partial class PPSI50 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackgrundPhoto",
                table: "Champions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgrundPhoto",
                table: "Champions");
        }
    }
}
