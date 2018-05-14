using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            int[,] matrix = new int[4, 4]
            {
                            {1, 0, 0, 0 },
                            {0, 1, 0, 0 },
                            {0, 0, 1, 0 },
                            {0, 0, 0, 1 }
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" {0} ", matrix[i, j]);
                }
                Console.WriteLine();

            }

            Console.ReadLine();
        }

    }

}
