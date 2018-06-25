using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldWebApp.Models
{
    public class Greeting
    {
        private long id;
        private string content;

        public long Id { get => id; set => id = value; }
        public string Content { get => content; set => content = value; }
    }
}
