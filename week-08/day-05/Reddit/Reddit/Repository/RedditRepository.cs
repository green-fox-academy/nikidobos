using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repository
{
    public class RedditRepository : IReddit<Post>
    {
        public RedditDbContext redditDbContext;
        public RedditRepository(RedditDbContext redditDbContext)
        {
            this.redditDbContext = redditDbContext;
        }

        public void ChangeVote(int id)
        {
        }

        public void Create(Post element)
        {
            redditDbContext.Posts.Add(element);
            redditDbContext.SaveChanges();
        }

        public void Delete(Post element)
        {
            redditDbContext.Remove(element);
        }

        public Post GetElementById(int id)
        {
            return redditDbContext.Posts.FirstOrDefault(x => x.Id.Equals(id));
        }

        public List<Post> Read()
        {
            return redditDbContext.Posts.ToList();
        }

        public void Update(Post element)
        {
            redditDbContext.Update(element);
            redditDbContext.SaveChanges();
        }
    }
}
