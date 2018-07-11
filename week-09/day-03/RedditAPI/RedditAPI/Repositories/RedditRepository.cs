using RedditAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPI.Repositories
{
    public class RedditRepository : IGenericRepository<Post>
    {
        private RedditDbContext dbContext;

        public RedditRepository(RedditDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Post post)
        {
            dbContext.Posts.Add(post);
            dbContext.SaveChanges();
        }

        public void Delete(Post post)
        {
            dbContext.Posts.Remove(post);
            dbContext.SaveChanges();
        }

        public List<Post> Read()
        {
            return dbContext.Posts.ToList();
        }

        public void Update(Post post)
        {
            dbContext.Posts.Update(post);
            dbContext.SaveChanges();
        }
    }
}
