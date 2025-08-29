using Microsoft.EntityFrameworkCore;
using core8_ember_oracle.Entities;

namespace core8_ember_oracle.Helpers
{// YourDbContext.cs
    public class OracleDbContext : DbContext
    {
        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options) { 

        }
        // Define DbSets for your entities
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .Property(e => e.CreatedAt)
                .HasDefaultValueSql("SYSDATE"); // Sets a default value using an Oracle SQL function

            modelBuilder.Entity<User>()
                .Property(e => e.UpdatedAt)
                .HasDefaultValueSql("SYSDATE"); // Sets a default value using an Oracle SQL function

            modelBuilder.Entity<Product>()
                .Property(e => e.CreatedAt)
                .HasDefaultValueSql("SYSDATE"); // Sets a default value using an Oracle SQL function

            modelBuilder.Entity<Product>()
                .Property(e => e.UpdatedAt)
                .HasDefaultValueSql("SYSDATE"); // Sets a default value using an Oracle SQL function

        }        
    }    
}