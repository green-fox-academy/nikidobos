using RedditAPI.Models;
using RedditAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPI.Services
{
    public class RedditService
    {
        private RedditRepository redditRepository;
        public RedditService(RedditRepository redditRepository)
        {
            this.redditRepository = redditRepository;
        }

        public void AddNewPost(Post post)
        {
            post.Timestamp = DateTime.Now.ToString("yyyy.MM.dd H:mm");
            redditRepository.Create(post);
        }

        public void RemovePost(Post post)
        {
            redditRepository.Delete(post);
        }

        public List<Post> GetAllPosts()
        {
            return redditRepository.Read();
        }

        public void UpdatePost(Post post)
        {
            redditRepository.Update(post);
        }
    }
}
