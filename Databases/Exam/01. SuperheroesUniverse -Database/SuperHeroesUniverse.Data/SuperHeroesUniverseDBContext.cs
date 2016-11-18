using SuperHeroesUniverse.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SuperHeroesUniverse.Data
{
    public class SuperHeroesUniverseDBContext : DbContext
    {
        public SuperHeroesUniverseDBContext()
            : base("SuperHeroesUniverse")
        {
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Fraction> Fractions { get; set; }

        public DbSet<Planet> Planets { get; set; }

        public DbSet<Power> Powers { get; set; }

        public DbSet<RelationShip> RelationShips { get; set; }

        public DbSet<Superhero> Superheroes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
