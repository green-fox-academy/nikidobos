using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`

                int[] ai = { 3, 4, 5, 6, 7 };
                Console.WriteLine(Sum(ai));
                Console.ReadLine();
        }
        public static int Sum(int[] summing)
        {
                int sum = 0;
                for (int i = 0; i < summing.Length; i++)
                {
                    sum += summing[i];
                }
                return sum;            
        }
    }
}