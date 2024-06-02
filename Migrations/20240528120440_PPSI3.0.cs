using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPSI3.Migrations
{
    /// <inheritdoc />
    public partial class PPSI30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Winrate",
                table: "Champions");

            migrationBuilder.CreateTable(
                name: "ChampionsAtribute",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampionId = table.Column<int>(type: "int", nullable: false),
                    Winrate = table.Column<int>(type: "int", nullable: false),
                    Heals = table.Column<bool>(type: "bit", nullable: false),
                    Shield = table.Column<bool>(type: "bit", nullable: false),
                    Poke = table.Column<bool>(type: "bit", nullable: false),
                    HasCC = table.Column<bool>(type: "bit", nullable: false),
                    MagicDamage = table.Column<bool>(type: "bit", nullable: false),
                    AttackDamage = table.Column<bool>(type: "bit", nullable: false),
                    Dash = table.Column<bool>(type: "bit", nullable: false),
                    CanOneShot = table.Column<bool>(type: "bit", nullable: false),
                    Tanky = table.Column<bool>(type: "bit", nullable: false),
                    Squishy = table.Column<bool>(type: "bit", nullable: false),
                    LateGame = table.Column<bool>(type: "bit", nullable: false),
                    IsGoodAgainstHeals = table.Column<int>(type: "int", nullable: false),
                    IsGoodAgainstShield = table.Column<int>(type: "int", nullable: false),
                    IsGoodAgainstPoke = table.Column<int>(type: "int", nullable: false),
                    IsGoodAgainstCC = table.Column<int>(type: "int", nullable: false),
                    IsGoodAgainstMagicDamage = table.Column<int>(type: "int", nullable: false),
                    IsGoodAgainstAttackDamage = table.Column<int>(type: "int", nullable: false),
                    IsGoodAgainstDash = table.Column<int>(type: "int", nullable: false),
                    IsGoodAgainstOneShot = table.Column<int>(type: "int", nullable: false),
                    IsGoodAgainstTanky = table.Column<int>(type: "int", nullable: false),
                    IsGoodAgainstSquishy = table.Column<int>(type: "int", nullable: false),
                    IsGoodAgainstLateGame = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionsAtribute", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChampionsAtribute");

            migrationBuilder.AddColumn<int>(
                name: "Winrate",
                table: "Champions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
