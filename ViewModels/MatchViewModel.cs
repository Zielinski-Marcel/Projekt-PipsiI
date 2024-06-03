using PPSI.Nowy_folder;
using PPSI3.Models;

namespace PPSI3.ViewModels
{
    public class MatchViewModel
    {
        Match match;
        GameMode gameMode;
        Map map;
        List<Player> players;
        List<Champion> champions;
        List<Summoner> summoners;
        List<Team> teams;
        
        

        public MatchViewModel(int matchId,List<Match> matches, List<Team> teams, List<Player> players, List<GameMode> gameModes, List<Champion> champions, List<Summoner> summoners, List<Map> maps)
        {
            List<Champion> Champions = new();
            List<Summoner> Summoners = new();
            this.match = Match.getMatchById(matchId, matches);
            this.gameMode = GameMode.getGameModeByMatchId(match.GameModeId, gameModes);
            this.players = Player.getPlayersByMatchId(matchId, players);
            foreach (Player player in players) 
            {
                Champions.Add(Champion.getChampionById(player.ChampionId,champions));
            }
            this.champions = Champions;
            foreach(Player player in players)
            {
                Summoners.Add(Summoner.getSummonerById(player.SummonerId, summoners));
            }
            this.summoners = Summoners;
            this.map = Map.getMapById(gameMode.MapId, maps);
            foreach(Player player in players)
            {
                this.teams.Add(Team.getTeamById(player.TeamId, teams));
            }
            this.teams=teams.Distinct().ToList();
        }

  
    }
}
