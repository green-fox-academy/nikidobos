using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloUserRestApp.Models
{
    public class Greeting
    {
        long id;
        string content;

        public long Id { get => id; set => id = value; }
        public string Content { get => content; set => content = value; }
    }
}
