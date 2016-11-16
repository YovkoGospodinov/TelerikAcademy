using SocialNetwork.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SocialNetwork.Data
{
    public class SocialNetworkContext : DbContext
    {
        public SocialNetworkContext()
            : base("SocialNetworkDatabase") {}

        public virtual IDbSet<FriendShip> FriendShips { get; set; }

        public virtual IDbSet<Image> Images { get; set; }

        public virtual IDbSet<Message> Messages { get; set; }

        public virtual IDbSet<Post> Posts { get; set; }

        public virtual IDbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
