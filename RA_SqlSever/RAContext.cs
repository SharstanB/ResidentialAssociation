using Microsoft.EntityFrameworkCore;
using RA_Infrastructure.Models;
using RA_Infrastructure.Models.Accounting;
using RA_Infrastructure.Models.Main;
using RA_Infrastructure.Models.Setting;

namespace RA_SqlSever
{
    public class RAContext : DbContext
    {
        public RAContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Finance> Finances { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<Residence> Residences { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Settings> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().HasMany(t => t.FirstSides)
            .WithOne(g => g.FirstSide)
            .HasForeignKey(g => g.FirstSideId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Member>().HasMany(t => t.SecondSides)
            .WithOne(g => g.SecondSide)
            .HasForeignKey(g => g.SecondSideId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Member>()
              .HasOne(a => a.Person)
              .WithOne(b => b.Member)
              .HasForeignKey<Member>(b => b.Member_ID);


        }
    }
}