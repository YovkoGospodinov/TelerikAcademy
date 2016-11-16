using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Models
{
    public class Message
    {
        public int Id { get; set; }

        [ForeignKey ("FriendShip")]
        public int FriendShipId { get; set; }

        public virtual FriendShip FriendShip { get; set; }

        public virtual User Author { get; set; }

        [ForeignKey ("Author")]
        public int AuthorId { get; set; }

        [Required]
        public string Content { get; set; }

        [Index]
        public DateTime SentOn { get; set; }


        public DateTime? SeenOn { get; set; }
    }
}
