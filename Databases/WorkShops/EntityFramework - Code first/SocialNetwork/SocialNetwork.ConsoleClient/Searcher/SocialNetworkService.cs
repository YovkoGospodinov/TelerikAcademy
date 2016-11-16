namespace SocialNetwork.ConsoleClient.Searcher
{
    using Data;
    using System;
    using System.Collections;
    using System.Linq;

    public class SocialNetworkService : ISocialNetworkService
    {
        private SocialNetworkContext socialNetwork = new SocialNetworkContext();

        public IEnumerable GetUsersAfterCertainDate(int year)
        {
            var searchedUsers = socialNetwork.Users.Where(u => u.RegisteredOn.Year >= year);

            return searchedUsers;
        }

        public IEnumerable GetPostsByUser(string username)
        {
            var searchedPosts = socialNetwork.Users.Where(u => u.Username == username).Select(u => u.Posts);

            if (searchedPosts == null)
            {
                return $"The user has no posts.";
            }
            return searchedPosts;
        }

        public IEnumerable GetFriendships(int page = 1, int pageSize = 25)
        {
            var searchedFriendShips = socialNetwork.FriendShips.Skip(page - 1).Take((page * pageSize));

            return searchedFriendShips;
        }

        public IEnumerable GetChatUsers(string username)
        {
            var chatUsers = socialNetwork.Messages.Where(m => m.FriendShip.FirstUser.Username == username || m.FriendShip.SecondUser.Username == username);

            return chatUsers;
        }
    }
}
