using System;

namespace _06_Bunnies_again
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
            Console.WriteLine(CountingBunnyEars(0));
            Console.ReadKey();            
        }

        public static int CountingBunnyEars(int numberOfBunnies)
        {
            int evenEars = 3;
            int oddEars = 2;
            if (numberOfBunnies == 0)
            {
                return 0;
            }
            else if (numberOfBunnies == 1)
            {
                return oddEars;
            }
            else if (numberOfBunnies % 2 == 0)
            {
                return CountingBunnyEars(numberOfBunnies - 1) + evenEars;
            }
            else
            {
                return CountingBunnyEars(numberOfBunnies - 1) + oddEars;
            }
        }

    }
}