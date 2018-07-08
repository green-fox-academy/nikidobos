using Reddit.Models;
using Reddit.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public class RedditService : IRedditService
    {
        public RedditRepository redditRepository;
        public RedditService(RedditRepository redditRepository)
        {
            this.redditRepository = redditRepository;
        }

        public void AddNewPost(Post post)
        {
            post.DateOfPost = DateTime.Now.ToString("yyyy.MM.dd H:mm");
            redditRepository.Create(post);
        }

        public void IncreaseVote(int id)
        {
            var forVoting = GetPostById(id);
            forVoting.NumberOfVotes++;
            redditRepository.Update(forVoting);
        }

        public void DeletePost(Post post)
        {
            redditRepository.Delete(post);
        }

        public List<Post> GetAllPosts()
        {
            return redditRepository.Read();
        }

        public Post GetPostById(int id)
        {
           return redditRepository.GetElementById(id);
        }

        public void UpdatePost(Post post)
        {
            redditRepository.Update(post);
        }

        public void DecreaseVote(int id)
        {
            var forVoting = GetPostById(id);
            forVoting.NumberOfVotes--;
            redditRepository.Update(forVoting);
        }
    }
}
