using Club.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Club.Models
{
    public class Fox : IFox
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public void DrinkTheFox(string drink)
        {

        }

        public void FeedTheFox(string food)
        {

        }

        public string GetName()
        {
            return Name;
        }

        public void Login(string input)
        {
            this.Name = input;
        }

        public void TeachTricks(string trick)
        {

        }
    }
}
