using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of bidimensional array (horizontal, vertical):");
            int horizontal = int.Parse(Console.ReadLine());
            int vertical = int.Parse(Console.ReadLine());

            float[,] array = new float[horizontal, vertical];

            for (int i = 0; i < horizontal; i++)
            {
                for (int j = 0; j < vertical; j++)
                {
                    Console.WriteLine($"Enter value for position: [{i},{j}]:");
                    array[i, j] = float.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The sum of the values in each line:");
            for (int i = 0; i < horizontal; i++)
            {
                float sum = 0;
                for (int j = 0; j < vertical; j++)
                {
                    sum += array[i, j];
                }
                Console.WriteLine($"Line {i}: {sum}");
            }

            Console.WriteLine("The sum of the values in each colum:");
            for (int j = 0; j < vertical; j++)
            {
                float sum = 0;
                for (int i = 0; i < horizontal; i++)
                {
                    sum += array[i, j];
                }
                Console.WriteLine($"Colum {j}: {sum}");
            }
        }
    }

}
