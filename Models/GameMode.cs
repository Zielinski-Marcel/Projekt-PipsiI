
namespace PPSI.Nowy_folder
{
    public class GameMode
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int MapId { get; set; }

        public int TeamSize { get; set; }
        public int TeamAmount { get; set; }
        public string Description { get; set; }

        internal static GameMode getGameModeByMatchId(int gameModeId, List<GameMode> gameModes)
        {
            foreach (GameMode gameMode in gameModes) { if (gameModeId == gameMode.Id) return gameMode; }
            throw new NotImplementedException();
        }
    }
}
