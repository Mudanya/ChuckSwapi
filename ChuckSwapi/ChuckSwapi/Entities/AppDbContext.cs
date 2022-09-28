using ChuckSwapi.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ChuckSwapi.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<People>()
                .HasMany(p => p.Films)
                .WithOne(p => p.People)
                .HasForeignKey(p => p.PeopleId);
            builder.Entity<Film>()
                .HasOne(f => f.People)
                .WithMany(f => f.Films)
                .HasForeignKey(f => f.PeopleId);
                
            builder.Entity<People>()
                .HasMany(p => p.Vehicles)
                .WithOne(p => p.People)
                .HasForeignKey(p => p.PeopleId);
            builder.Entity<Vehicle>()
                .HasOne(f => f.People)
                .WithMany(f => f.Vehicles)
                .HasForeignKey(f => f.PeopleId);
                
            builder.Entity<People>()
                .HasMany(p => p.Species)
                .WithOne(p => p.People)
                .HasForeignKey(p => p.PeopleId);
            builder.Entity<Species>()
                .HasOne(f => f.People)
                .WithMany(f => f.Species)
                .HasForeignKey(f => f.PeopleId);
                
            builder.Entity<People>()
                .HasMany(p => p.Vehicles)
                .WithOne(p => p.People)
                .HasForeignKey(p => p.PeopleId);
            builder.Entity<Vehicle>()
                .HasOne(f => f.People)
                .WithMany(f => f.Vehicles)
                .HasForeignKey(f => f.PeopleId);
                
        }
        public DbSet<People> People { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
