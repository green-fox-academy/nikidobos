using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    interface IRedditService
    {
        //CRUD
        void AddNewPost(Post post);
        List<Post> GetAllPosts();
        void UpdatePost(Post post);
        void DeletePost(Post post);
    }
}
