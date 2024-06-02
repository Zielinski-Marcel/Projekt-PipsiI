using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using PPSI3.Models;

namespace PPSI.Nowy_folder
{
    public class DB : DbContext
    {
        
        public DbSet<Map> Maps { get; set; }
        public DbSet<GameMode> GameModes { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Summoner> Summoners { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Champion> Champions { get; set; }
        public DbSet<ChampionsRole> ChampionsRole { get; set; }
        public DbSet<ChampionsAtribute> ChampionsAtribute { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemsAtribute> ItemsAtributes { get; set; }
        public DbSet<Boot>  Boots { get; set; }
        public DbSet<BootsAtribute> BootsAtributes { get; set; }
        public DbSet<Trinket> Trinkets { get; set; }


        public DB(DbContextOptions options) : base(options)
        {

        }
        
    }
   
}
