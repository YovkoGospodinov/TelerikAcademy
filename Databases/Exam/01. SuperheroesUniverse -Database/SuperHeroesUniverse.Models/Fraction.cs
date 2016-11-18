using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroesUniverse.Models
{
    public class Fraction
    {
        private ICollection<Superhero> superheroes;
        private ICollection<Planet> planets;

        public Fraction()
        {
            this.superheroes = new HashSet<Superhero>();
            this.planets = new HashSet<Planet>();
        }

        public int Id { get; set; }

        [Index(IsUnique = true), MinLength(2), MaxLength(30)]
        [Required]
        public string Name { get; set; }

        public AlignmentType Alignment { get; set; }

        public virtual ICollection<Planet> Planets
        {
            get { return this.planets; }
            set { this.planets = value; }
        }

        public virtual ICollection<Superhero> Superheroes
        {
            get { return this.superheroes; }
            set { this.superheroes = value; }
        }
    }
}
