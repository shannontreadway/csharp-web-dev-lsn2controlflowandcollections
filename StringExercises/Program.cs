using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string greenEggsAndHamLine = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

            string[] greenEggsAndHamArray = greenEggsAndHamLine.Split(' ');
            Console.WriteLine(string.Join(",", greenEggsAndHamArray));

            string[] greenEggsAndHamSentenceArray = greenEggsAndHamLine.Split('.');
            Console.WriteLine(string.Join(";", greenEggsAndHamSentenceArray));
        }
    }
}
