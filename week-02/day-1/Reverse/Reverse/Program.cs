using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] aj = { 3, 4, 5, 6, 7 };
            int[] reversedArray = new int[5];

            int j = 0;
            for (int i = aj.Length - 1; i >= 0 ; i--)
            {
                reversedArray[j] = aj[i];
                j++;
            }
            foreach (var item in reversedArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}