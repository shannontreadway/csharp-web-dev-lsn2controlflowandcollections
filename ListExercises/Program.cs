using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print sum of even digits in a list
            List<int> integersList = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            int sumOfEvenDigits = 0;
            foreach (int digit in integersList)
            {
                if (digit % 2 == 0)
                    sumOfEvenDigits += digit;
            }
            Console.WriteLine(sumOfEvenDigits);

            //Print words that have exactly 5 letters in a list
            List<string> wordString = new List<string> { "write", "a", "static", "method", "to", "print", "out", "each", "word", "in", "a", "list", "that", "has", "exactly", "five", "letters"};
            foreach (string word in wordString)
            {
                if (word.Length == 5)
                    Console.WriteLine(word);
            }
            Console.WriteLine("What word length should we search for?");
            int wordSearchLength = int.Parse(Console.ReadLine());
            foreach (string word in wordString)
            {
                if (word.Length == wordSearchLength)
                    Console.WriteLine(word);
            }
        }
    }
}