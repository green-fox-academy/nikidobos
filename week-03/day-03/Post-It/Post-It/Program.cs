using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_It
{
    class Program
    {
        static void Main(string[] args)
        {
            //an orange with blue text: "Idea 1"
            //a pink with black text: "Awesome"
            //a yellow with green text: "Superb!"

            Postit firstPostIt = new Postit("orange", "Idea 1", "blue");
            Console.WriteLine($"{firstPostIt.backgroungColor}, {firstPostIt.text}, {firstPostIt.textColor}");

            
            Postit secondPostIt = new Postit("pink", "Awesome", "black");
            Console.WriteLine($"{secondPostIt.backgroungColor}, {secondPostIt.text}, {secondPostIt.textColor}");

            Postit thirdPostIt = new Postit("yellow", "Superb", "green");
            Console.WriteLine($"{thirdPostIt.backgroungColor}, {thirdPostIt.text}, {thirdPostIt.textColor}");

            

            Console.ReadKey();
        }

    }

}
