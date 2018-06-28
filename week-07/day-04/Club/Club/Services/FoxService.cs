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



        public void TeachTricks(string trick)
        {
            List<string> learnttricks = new List<string>();
            learnttricks.Add(trick);
        }

        public void FeedTheFox(string food)
        {
            List<string> foodStore = new List<string>();
            foodStore.Add(food);
        }

        public void DrinkTheFox(string drink)
        {
            List<string> drinkStore = new List<string>();
            drinkStore.Add(drink);
        }
    }
}
