using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Fox class with !3 properties(name, type, color)! Fill a list with at least !5 foxes!, 
            //it's up to you how you name/create them! Write a LINQ Expression to !find the foxes with green color!!
            //Write a LINQ Expression to !find the foxes with green color and fulvipes type!

            List<Fox> foxes = new List<Fox>
            {
                new Fox() {Name = "Foxy", Type = "Pallida", Color = "green" },
                new Fox() { Name = "Stuart", Type = "Fulvipes", Color = "red" },
                new Fox() { Name = "Peter Griffin", Type = "Wild", Color = "green" },
                new Fox() { Name = "Brian", Type = "Wild", Color = "foxgray" },
                new Fox() { Name = "Nathan", Type = "Fulvipes", Color = "brown" }
            };                                    
        }
    }
}
