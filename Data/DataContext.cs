using Microsoft.EntityFrameworkCore;
using Equb.Models;

namespace Equb.Data
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("EkubDatabase"));
        }

        public DbSet<Users>? Users { get; set; }
        public DbSet<EqubInfo>? EqubInfo { get; set; }
        public DbSet<MemberInvite>? MemberInvites { get; set; }
        public DbSet<Enrollment>? Enrollment { get; set; }
    }
}
