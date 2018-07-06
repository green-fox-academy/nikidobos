using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class Reddit
    {
        public int Id { get; set; }
        public int NumberOfVotes { get; set; }
        public string Post { get; set; }
    }
}
