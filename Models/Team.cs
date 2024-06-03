
namespace PPSI.Nowy_folder
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }


        internal static Team getTeamById(int teamId, List<Team> teams)
        {
            foreach (Team team in teams) {if(team.Id == teamId) return team; }
            throw new NotImplementedException();
        }
    }
}
