using Club.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Club.Services
{
    public class FoxService : IFox
    {
        Fox fox = new Fox();
        private FoodDrink menu;
        private List<Fox> foxes;
        private List<string> learnttricks;
        private List<string> foodStore;

        public FoxService()
        {
            foxes = new List<Fox>();
        }

        public void AddFox(string name)
        {
            fox.Name = name;
            foxes.Add(fox);
        }

        public Fox GetFox(string name)
        {
            return foxes.Where(f => f.Name == name).Single();
        }

        public string FeedTheFox()
        {
            return menu.foodStore[0];
        }

        public string TeachTricks()
        {
            throw new NotImplementedException();
        }
    }
}
