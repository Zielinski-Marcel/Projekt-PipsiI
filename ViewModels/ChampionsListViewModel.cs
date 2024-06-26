﻿using PoroCounter2.Models;

namespace PoroCounter2.ViewModels
{
    public class ChampionsListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Photo { get; set; }
        public bool Top { get; set; }

        public bool Jungle { get; set; }

        public bool Mid { get; set; }

        public bool Bot { get; set; }

        public bool Supp { get; set; }

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
        public ChampionsListViewModel(Champion champion, ChampionsAtribute championsAtribute, ChampionsRole championsRole)
        {
            Id = champion.Id;
            Name = champion.Name;
            Photo = champion.Photo;
            Top = championsRole.Top;
            Jungle = championsRole.Jungle;
            Mid = championsRole.Mid;
            Bot = championsRole.Bot;
            Supp = championsRole.Supp;
            Winrate = championsAtribute.Winrate;
            Heals = championsAtribute.Heals;
            Shield = championsAtribute.Shield;
            Poke = championsAtribute.Poke;
            HasCC = championsAtribute.HasCC;
            MagicDamage = championsAtribute.MagicDamage;
            AttackDamage = championsAtribute.AttackDamage;
            Dash = championsAtribute.Dash;
            CanOneShot = championsAtribute.CanOneShot;
            Tanky = championsAtribute.Tanky;
            Squishy = championsAtribute.Squishy;
            LateGame = championsAtribute.LateGame;
            IsGoodAgainstHeals = championsAtribute.IsGoodAgainstHeals;
            IsGoodAgainstShield = championsAtribute.IsGoodAgainstShield;
            IsGoodAgainstPoke = championsAtribute.IsGoodAgainstPoke;
            IsGoodAgainstCC = championsAtribute.IsGoodAgainstCC;
            IsGoodAgainstMagicDamage = championsAtribute.IsGoodAgainstMagicDamage;
            IsGoodAgainstAttackDamage = championsAtribute.IsGoodAgainstAttackDamage;
            IsGoodAgainstDash = championsAtribute.IsGoodAgainstDash;
            IsGoodAgainstOneShot = championsAtribute.IsGoodAgainstOneShot;
            IsGoodAgainstTanky = championsAtribute.IsGoodAgainstTanky;
            IsGoodAgainstSquishy = championsAtribute.IsGoodAgainstSquishy;
            IsGoodAgainstLateGame = championsAtribute.IsGoodAgainstLateGame;
        }
        public static List<ChampionsListViewModel> GenerateListOfChampions(List<Champion> Champions, List<ChampionsAtribute> ChampionsAtributes, List<ChampionsRole> ChampionsRoles)
        {
            var result = from champion in Champions
                         join attribute in ChampionsAtributes on champion.Id equals attribute.ChampionId
                         join role in ChampionsRoles on champion.Id equals role.championId
                         select new ChampionsListViewModel(champion, attribute, role);
            List<ChampionsListViewModel> champs = result.ToList();

            return champs;
        }
    }
}
