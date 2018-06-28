using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Club.Services
{
    public class FoxService : IFox
    {
        private string name;
        private List<string> learnttricks;
        private List<string> foodStore;
        private List<string> drinkStore;

        public void Login(string input)
        {
            this.name = input;
        }

        public void LearnTricks(string trick)
        {
            learnttricks.Add(trick);
        }

        public void FeedTheFox(string food)
        {
            foodStore.Add(food);
        }

        public void DrinkTheFox(string drink)
        {
            drinkStore.Add(drink);
        }
    }
}
