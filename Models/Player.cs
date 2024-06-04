
namespace PPSI.Nowy_folder
{
    public class Player
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int TeamId { get; set; }
        public int ChampionId { get; set; }
        public int SummonerId { get; set; }
        public int EquipmentId { get; set; }
        public int Kills { get; set;}
        public int Deaths { get; set; }
        public int Asists { get; set; }
        public int Cs {  get; set; }
        public int Gold { get; set; }

        internal static List<Player>? getPlayersByMatchId(int matchId, List<Player> players)
        {
            List<Player>? result = new List<Player>();
            foreach (Player player in players)
            {
                if (player.MatchId == matchId) { result.Add(player); }
            }
            return result;
        }
    }
}
