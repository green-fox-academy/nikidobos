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
            throw new NotImplementedException();
        }

        public void Delete(Post post)
        {
            throw new NotImplementedException();
        }

        public List<Post> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
