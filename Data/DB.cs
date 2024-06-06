using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PoroCounter2.Models;

namespace PoroCounter2.Data
{
    public class DB : IdentityDbContext<Summoner>
    {

        public DbSet<Summoner> Summoners { get; set; }

        public DbSet<Champion> Champions { get; set; }
        public DbSet<ChampionsRole> ChampionsRole { get; set; }
        public DbSet<ChampionsAtribute> ChampionsAtribute { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemsAtribute> ItemsAtributes { get; set; }
        public DbSet<Boot> Boots { get; set; }
        public DbSet<BootsAtribute> BootsAtributes { get; set; }
        public DbSet<Trinket> Trinkets { get; set; }


        public DB(DbContextOptions options) : base(options)
        {

        }

    }
}
