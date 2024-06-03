using PPSI.Nowy_folder;
using PPSI3.Models;

namespace PPSI3.ViewModels
{
    public class MatchViewModel
    {
        Match match;
        List<Match> matches;
        List<Team> teams;
        List<Map> maps;
        List<Player> players;
        List<GameMode> gameModes;
        List<Champion> champions;
        List<Summoner> summoners;
        public MatchViewModel(int matchId,List<Match> matches, List<Team> teams, List<Player> players, List<GameMode> gameModes, List<Champion> champions, List<Summoner> summoners, List<Map> maps)
        {
            this.match = Match.getMatchById(matchId, matches);
            this.gameModes = GameMode.getGameModeByMatchId(matchId, gameModes);
            this.teams = teams;
            this.players = players;
            
            this.champions = champions;
            this.summoners = summoners;
            this.maps = maps;
        }

  
    }
}
