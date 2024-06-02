namespace PPSI3.Models
{
    public class ChampionsRole
    {
        public int Id { get; set; }
        public int championId { get; set; }
        public bool Top { get; set; }

        public bool Jungle { get; set; }

        public bool Mid { get; set; }

        public bool Bot { get; set; }

        public bool Supp { get; set; }
    }
}
