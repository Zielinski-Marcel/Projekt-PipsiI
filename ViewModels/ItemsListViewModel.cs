using PoroCounter2.Models;

namespace PoroCounter2.ViewModels
{
    public class ItemsListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
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
        public ItemsListViewModel(Item item, ItemsAtribute itemsAtribute)
        {
            Id = item.Id;
            Name = item.Name;
            Photo = item.Photo;
            Heals = itemsAtribute.Heals;
            Shield = itemsAtribute.Shield;
            Poke = itemsAtribute.Poke;
            HasCC = itemsAtribute.HasCC;
            MagicDamage = itemsAtribute.MagicDamage;
            AttackDamage = itemsAtribute.AttackDamage;
            Dash = itemsAtribute.Dash;
            CanOneShot = itemsAtribute.CanOneShot;
            Tanky = itemsAtribute.Tanky;
            Squishy = itemsAtribute.Squishy;
            LateGame = itemsAtribute.LateGame;
            IsGoodAgainstHeals = itemsAtribute.IsGoodAgainstHeals;
            IsGoodAgainstShield = itemsAtribute.IsGoodAgainstShield;
            IsGoodAgainstPoke = itemsAtribute.IsGoodAgainstPoke;
            IsGoodAgainstCC = itemsAtribute.IsGoodAgainstCC;
            IsGoodAgainstMagicDamage = itemsAtribute.IsGoodAgainstMagicDamage;
            IsGoodAgainstAttackDamage = itemsAtribute.IsGoodAgainstAttackDamage;
            IsGoodAgainstDash = itemsAtribute.IsGoodAgainstDash;
            IsGoodAgainstOneShot = itemsAtribute.IsGoodAgainstOneShot;
            IsGoodAgainstTanky = itemsAtribute.IsGoodAgainstTanky;
            IsGoodAgainstSquishy = itemsAtribute.IsGoodAgainstSquishy;
            IsGoodAgainstLateGame = itemsAtribute.IsGoodAgainstLateGame;
        }
        public static List<ItemsListViewModel> GenerateListOfItems(List<Item> Items, List<ItemsAtribute> ItemsAtributes)
        {
            var result = from item in Items
                         join attribute in ItemsAtributes on item.Id equals attribute.ItemId
                         select new ItemsListViewModel(item, attribute);
            List<ItemsListViewModel> items = result.ToList();

            return items;
        }
    }
}
