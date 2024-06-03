
namespace PPSI.Nowy_folder
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Team>? getTeamsByGameModeId(int gameModeId, List<Team> teams)
        {
            List<Team> correctTeams = new List<Team>();
            foreach (Team team in teams)
            {
                if(team.Id == gameModeId) 
                {
                    
                } 
            }
            throw new NotImplementedException();
        }
    }
}
