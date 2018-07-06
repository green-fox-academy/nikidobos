using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int NumberOfVotes { get; set; }
        public string PostText { get; set; }
    }
}
