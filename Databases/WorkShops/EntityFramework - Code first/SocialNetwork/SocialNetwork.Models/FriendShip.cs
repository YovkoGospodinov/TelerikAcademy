using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Models
{
    public class FriendShip
    {
        private ICollection<Message> messages;

        public FriendShip()
        {
            messages = new List<Message>();
        }

        public int Id { get; set; }

        [Required]
        public User FirstUser { get; set; }

        [ForeignKey ("FirstUser")]
        public int FirstUserId { get; set; }

        [Required]
        public User SecondUser { get; set; }

        [ForeignKey ("SecondUser")]
        public int SecondUserId { get; set; }

        [Index]
        public bool Approved { get; set; }

        public DateTime FriendsSince { get; set; }

        public virtual ICollection<Message> Messages
        {
            get { return this.messages; }
            set { this.messages = value; }
        }
    }
}
