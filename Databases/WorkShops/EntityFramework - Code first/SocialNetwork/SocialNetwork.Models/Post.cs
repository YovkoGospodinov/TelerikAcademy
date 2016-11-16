using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Models
{
    public class Post
    {
        private ICollection<User> users;

        public Post()
        {
            users = new List<User>();
        }

        public int Id { get; set; }

        [MinLength(10)]
        public string Content { get; set; }

        public DateTime PostedOn { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
