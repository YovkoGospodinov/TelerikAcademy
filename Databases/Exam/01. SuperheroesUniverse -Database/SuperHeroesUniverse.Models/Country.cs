using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroesUniverse.Models
{
    public class Country
    {
        private ICollection<City> cities;

        public Country()
        {
            this.cities = new HashSet<City>();
        }

        public int Id { get; set; }

        [Index(IsUnique = true), MinLength(2), MaxLength(30)]
        [Required]
        public string Name { get; set; }

        public int PlanetId { get; set; }

        public virtual Planet Planet { get; set; }

        public virtual ICollection<City> Cities
        {
            get { return this.cities; }
            set { this.cities = value; }
        }
    }
}
