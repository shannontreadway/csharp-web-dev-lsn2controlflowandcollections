using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = {1, 1, 2, 3, 5, 8};
            //Print each element in the array
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
            
            Console.WriteLine("\n");

            //Print only the odd numbers in the array
            for (int i = 0; i < 6; i++)
            {
                if (numsArray[i] % 2 != 0)
                Console.WriteLine(numsArray[i]);
            }
        }
    }
}
