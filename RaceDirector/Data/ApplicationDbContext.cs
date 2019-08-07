using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RaceDirector.Models;

namespace RaceDirector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceClass> RaceClasses { get; set; }
        public DbSet<RaceResult> RaceResults { get; set; }
        public DbSet<Track> Tracks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
