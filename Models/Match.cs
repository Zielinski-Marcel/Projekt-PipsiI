
using PPSI3.Migrations;

namespace PPSI.Nowy_folder
{
    public class Match
    {
        public int Id { get; set; }
        public int GameModeId { get; set; }

        public static Match getMatchById(int matchId, List<Match> matches)
        {
            foreach (Match match in matches) { if (match.Id == matchId) return match; }
            throw new NotImplementedException();
        }
    }
}
