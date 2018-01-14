
using Microsoft.EntityFrameworkCore;

namespace MyWebAPI.Entities
{
    public class RDSContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseMySql(Helpers.GetRDSConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().ToTable("blogs");
            modelBuilder.Entity<Post>().ToTable("posts");
        }
    }
}
