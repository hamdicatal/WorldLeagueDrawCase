using Microsoft.EntityFrameworkCore;
using WorldLeagueDraw.API.Entities;

namespace WorldLeagueDraw.API.Data.MSSQL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<DrawResult> DrawResults { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Team>().HasData(
            //    DataContextSeed.PrepareTeamList(countries).ToArray()
            //);
        }
    }
}
