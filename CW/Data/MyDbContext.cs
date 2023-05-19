using CW.Data;
using Microsoft.EntityFrameworkCore;

namespace CW.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options){ 

        }

        public DbSet<Member> Members { get; set; }

        public DbSet<Cause> Causes { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CauseConfiguration());
            // other configuration here
        }
    }
}
