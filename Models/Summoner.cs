
namespace PPSI.Nowy_folder
{
    public class Summoner
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static Summoner getSummonerById(int summonerId, List<Summoner> summoners)
        {
            foreach(var summoner in summoners)
            {
                if(summoner.Id == summonerId)
                    return summoner;
            }
            throw new NotImplementedException();
        }
    }
}
