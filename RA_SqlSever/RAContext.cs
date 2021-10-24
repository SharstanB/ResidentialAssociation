using Microsoft.EntityFrameworkCore;
using RA_Infrastructure.Models.Finance;
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

        public DbSet<Settings> Settings { get; set; }
    }
}