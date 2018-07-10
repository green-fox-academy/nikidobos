using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.ViewModels
{
    public class RedditViewModel
    {
        public List<Post> Posts { get; set; }
        public User User { get; set; }
    }
}
