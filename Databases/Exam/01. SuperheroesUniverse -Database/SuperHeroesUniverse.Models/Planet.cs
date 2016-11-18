using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroesUniverse.Models
{
    public class Planet
    {
        private ICollection<Country> coutries;
        private ICollection<Fraction> fractions;

        public Planet()
        {
            this.coutries = new HashSet<Country>();
        }

        public int Id { get; set; }

        [Index(IsUnique = true), MinLength(2), MaxLength(30)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Country> Countries
        {
            get { return this.coutries; }
            set { this.coutries = value; }
        }

        public virtual ICollection<Fraction> Fractions
        {
            get { return this.fractions; }
            set { this.fractions = value; }
        }
    }
}
