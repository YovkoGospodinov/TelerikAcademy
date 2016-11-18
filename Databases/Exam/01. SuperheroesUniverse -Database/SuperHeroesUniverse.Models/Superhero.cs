using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroesUniverse.Models
{
    public class Superhero
    {
        private ICollection<Power> powers;
        private ICollection<Fraction> fractions;
        private ICollection<RelationShip> relationShip;

        public Superhero()
        {
            this.powers = new HashSet<Power>();
            this.fractions = new HashSet<Fraction>();
            this.relationShip = new HashSet<RelationShip>();
        }

        public int Id { get; set; }

        [Index(IsUnique = true), MinLength(3), MaxLength(60)]
        [Required]
        public string Name { get; set; }

        [Index(IsUnique = true), MinLength(3), MaxLength(20)]
        [Required]
        public string SecretIdentity { get; set; }

        [Required]
        public AlignmentType Alignment { get; set; }

        public int CityThatProtectsId { get; set; }

        public virtual City CityThatProtects { get; set; }

        [Required]
        [MinLength(1)]
        public string Story { get; set; }

        public virtual ICollection<Power> Powers
        {
            get { return this.powers; }
            set { this.powers = value; }
        }

        public virtual ICollection<Fraction> Fractions
        {
            get { return this.fractions; }
            set { this.fractions = value; }
        }

        public virtual ICollection<RelationShip> RelationShip
        {
            get { return this.relationShip; }
            set { this.relationShip = value; }
        }
    }
}
