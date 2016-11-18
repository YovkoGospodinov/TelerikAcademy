using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroesUniverse.Models
{
    public class City
    {
        private ICollection<Superhero> superheroes;

        public City()
        {
            this.superheroes = new HashSet<Superhero>();
        }

        public int Id { get; set; }

        [Index(IsUnique = true), MinLength(2), MaxLength(30)]
        [Required]
        public string Name { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Superhero> Superheroes
        {
            get { return this.superheroes; }
            set { this.superheroes = value; }
        }
    }
}
