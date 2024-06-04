using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPSI3.Migrations
{
    /// <inheritdoc />
    public partial class BDF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "Players");
        }
    }
}
