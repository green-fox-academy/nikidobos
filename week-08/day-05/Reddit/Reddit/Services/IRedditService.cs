using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public interface IRedditService
    {
        //CRUD
        void AddNewPost(Post post);
        List<Post> GetAllPosts();
        void UpdatePost(Post post);
        void DeletePost(Post post);
        Post GetPostById(int id);
        void IncreaseVote(int id);
    }
}
