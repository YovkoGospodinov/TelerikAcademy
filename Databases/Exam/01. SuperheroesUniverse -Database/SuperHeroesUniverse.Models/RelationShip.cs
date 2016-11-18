using System.ComponentModel.DataAnnotations;

namespace SuperHeroesUniverse.Models
{
    public class RelationShip
    {
        public int Id { get; set; }

        public RelationshipType RelationShipType { get; set; }

        public int FirstSuperheroId { get; set; }

        [Required]
        public Superhero FirstSuperhero { get; set; }

        public int SecondSuperheroId { get; set; }

        [Required]
        public Superhero SecondSuperhero { get; set; }
    }
}
