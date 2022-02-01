using Microsoft.EntityFrameworkCore;
using RPGHelper.Context.Models.DataBase;
using RPGHelper.Context.Models.WarhammerFantasy.Character;
using RPGHelper.Models.Models.WarhammerFantasy;

namespace RPGHelper.Context.InfoTables.WarhammerFantasy;

public class WarhammerContext : DbContext
{
    public DbSet<PlayerCharacter> PlayerCharacters { get; set; }
    public DbSet<Player> PlayerList { get; set; }
    public DbSet<Talent> Talents { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=/home/qnku/RiderProjects/RPGHelper/RPGHelper.Context/Data.db");
        base.OnConfiguring(optionsBuilder);
    }
}