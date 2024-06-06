using PoroCounter2.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;

namespace PoroCounter2.Models
{
    public class ChampionsAtribute
    {
        public int Id { get; set; }
        public int ChampionId { get; set; }
        public int Winrate { get; set; }
        public bool Heals { get; set; }
        public bool Shield { get; set; }
        public bool Poke { get; set; }
        public bool HasCC { get; set; }
        public bool MagicDamage { get; set; }
        public bool AttackDamage { get; set; }
        public bool Dash { get; set; }
        public bool CanOneShot { get; set; }
        public bool Tanky { get; set; }
        public bool Squishy { get; set; }
        public bool LateGame { get; set; }
        public int IsGoodAgainstHeals { get; set; }
        public int IsGoodAgainstShield { get; set; }
        public int IsGoodAgainstPoke { get; set; }
        public int IsGoodAgainstCC { get; set; }
        public int IsGoodAgainstMagicDamage { get; set; }
        public int IsGoodAgainstAttackDamage { get; set; }
        public int IsGoodAgainstDash { get; set; }
        public int IsGoodAgainstOneShot { get; set; }
        public int IsGoodAgainstTanky { get; set; }
        public int IsGoodAgainstSquishy { get; set; }
        public int IsGoodAgainstLateGame { get; set; }

        public static ChampionsAtribute getChampionsAtributeById(int id, List<ChampionsAtribute> championList)
        {
            foreach (ChampionsAtribute champion in championList)
            {
                if (champion.ChampionId == id)
                    return champion;

            }
            return null;
        }

        public static List<ChampionsListViewModel> RoleFilter(List<ChampionsListViewModel> Champions, string role)
        {
            RoleFilter enemyRole = new RoleFilter();
            switch (role.ToLower())
            {
                case "bot":
                    enemyRole.Bot = true;
                    break;
                case "mid":
                    enemyRole.Mid = true;
                    break;
                case "supp":
                    enemyRole.Supp = true;
                    break;
                case "jungle":
                    enemyRole.Jungle = true;
                    break;
                case "top":
                    enemyRole.Top = true;
                    break;
                default:
                    return new List<ChampionsListViewModel>();
            }
            var filteredChampions = Champions.Where(champion =>
                (enemyRole.Bot && champion.Bot) ||
                (enemyRole.Mid && champion.Mid) ||
                (enemyRole.Supp && champion.Supp) ||
                (enemyRole.Jungle && champion.Jungle) ||
                (enemyRole.Top && champion.Top)
            ).ToList();

            return filteredChampions;
        }

        public static List<Champion> SelectChampionAgainstLaner(ChampionsAtribute enemyLaner, List<ChampionsListViewModel> Champions, List<Champion> champions)
        {
            int maxScore = 0;
            Champion bestChampion;
            List<Champion> bestChampions = new List<Champion>();
            foreach (ChampionsListViewModel champion in Champions)
            {

                if (enemyLaner.ChampionId != champion.Id)
                {
                    int scoreCounting = 0;
                    if (enemyLaner.AttackDamage)
                    {
                        scoreCounting += champion.IsGoodAgainstAttackDamage;
                    }

                    if (enemyLaner.MagicDamage)
                    {
                        scoreCounting += champion.IsGoodAgainstMagicDamage;
                    }

                    if (enemyLaner.Shield)
                    {
                        scoreCounting += champion.IsGoodAgainstShield;
                    }

                    if (enemyLaner.Heals)
                    {
                        scoreCounting += champion.IsGoodAgainstHeals;
                    }

                    if (enemyLaner.Tanky)
                    {
                        scoreCounting += champion.IsGoodAgainstTanky;
                    }

                    if (enemyLaner.Squishy)
                    {
                        scoreCounting += champion.IsGoodAgainstSquishy;
                    }

                    if (enemyLaner.HasCC)
                    {
                        scoreCounting += champion.IsGoodAgainstCC;
                    }

                    if (enemyLaner.Dash)
                    {
                        scoreCounting += champion.IsGoodAgainstDash;
                    }

                    if (enemyLaner.Poke)
                    {
                        scoreCounting += champion.IsGoodAgainstPoke;
                    }

                    if (enemyLaner.CanOneShot)
                    {
                        scoreCounting += champion.IsGoodAgainstOneShot;
                    }

                    if (enemyLaner.LateGame)
                    {
                        scoreCounting += champion.IsGoodAgainstLateGame;
                    }

                    if (maxScore < scoreCounting)
                    {
                        maxScore = scoreCounting;
                        bestChampions.Clear();
                        bestChampion = Champion.getChampionById(champion.Id, champions);
                        bestChampions.Add(bestChampion);
                    }
                    else if (maxScore == scoreCounting)
                    {
                        bestChampion = Champion.getChampionById(champion.Id, champions);
                        bestChampions.Add(bestChampion);
                    }

                }
            }



            return bestChampions;
        }
    }



}
