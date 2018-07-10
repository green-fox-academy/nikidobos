using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repository
{
    public class UserRepository : IReddit<User>
    {
        public RedditDbContext redditDbContext;
        public UserRepository(RedditDbContext redditDbContext)
        {
            this.redditDbContext = redditDbContext;
        }

        public void Create(User user)
        {
            redditDbContext.Add(user);
            redditDbContext.SaveChanges();
        }

        public void Delete(User user)
        {
            redditDbContext.Remove(user);
            redditDbContext.SaveChanges();
        }

        public User GetElementById(int id)
        {
            return redditDbContext.Users.FirstOrDefault(x => x.Id.Equals(id));
        }

        public List<User> Read()
        {
            return redditDbContext.Users.ToList();
        }

        public void Update(User user)
        {
            redditDbContext.Update(user);
            redditDbContext.SaveChanges();
        }
    }
}
