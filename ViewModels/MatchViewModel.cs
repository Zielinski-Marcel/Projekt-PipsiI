using PPSI.Nowy_folder;
using PPSI3.Models;

namespace PPSI3.ViewModels
{
    public class MatchViewModel
    {
        public Match match { get; set; }
        public GameMode gameMode { get; set; }
        public Map map { get; set; }
        public List<Player> players { get; set; }
        public List<Champion> champions { get; set; }
        public List<Summoner> summoners { get; set; }
        public List<Team> teams { get; set; }
        public List<Equipment> equipments { get; set; }
        
        

        public MatchViewModel(int matchId,List<Match> matches, List<Team> teams, List<Player> players, List<GameMode> gameModes, List<Champion> champions, List<Summoner> summoners, List<Map> maps, List<Equipment> equipments)
        {
            List<Champion> Champions = new List<Champion>();
            List<Summoner> Summoners = new List<Summoner>();
            List<Equipment> Equipments = new List<Equipment>();

            this.match = Match.getMatchById(matchId, matches);
            this.gameMode = GameMode.getGameModeByMatchId(match.GameModeId, gameModes);
            this.map = Map.getMapById(gameMode.MapId, maps);
            this.players = Player.getPlayersByMatchId(matchId, players);
            foreach (Player player in players) 
            {
                Champions.Add(Champion.getChampionById(player.ChampionId,champions));
                Summoners.Add(Summoner.getSummonerById(player.SummonerId, summoners));
                Equipments.Add(Equipment.getEquipmentsById(player.EquipmentId, equipments));
            }
            this.champions = Champions;
            this.summoners = Summoners;
            this.equipments = equipments;
            this.teams = teams;
        }

  
    }
}
