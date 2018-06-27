using Greet_Someone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greet_Someone.Services
{
    public class GreetService : IGreet
    {
        private string name;

        public string Greet()
        {
           return name;
        }

        public void SetName(string input)
        {
            this.name = input;
        }
    }
}

