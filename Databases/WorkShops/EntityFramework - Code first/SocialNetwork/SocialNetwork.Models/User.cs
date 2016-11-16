using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Models
{
    public class User
    {
        private ICollection<Image> images;
        private ICollection<Post> posts;
        private ICollection<Message> messages;

        public User()
        {
            images = new List<Image>();
            posts = new List<Post>();
            messages = new List<Message>();
        }

        [PrimaryKey]
        public int Id { get; set; }

        [Index(IsUnique = true), MinLength(4), MaxLength(20)]
        public string Username { get;  set; }

        [MaxLength(50), MinLength(2)]
        public string FirstName { get; set; }

        [MaxLength(50), MinLength(2)]
        public string LastName { get; set; }

        public DateTime RegisteredOn { get; set; }

        public virtual ICollection<Image> Images
        {
            get { return this.images; }
            set { this.images = value; }
        }

        public virtual ICollection<Post> Posts
        {
            get { return this.posts; }
            set { this.posts = value; }
        }

        public virtual ICollection<Message> Messages
        {
            get { return this.messages; }
            set { this.messages = value; }
        }
    }
}
