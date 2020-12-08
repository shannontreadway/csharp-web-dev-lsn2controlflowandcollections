using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> studentIDs = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter the student IDs (or ENTER to finish):");
            int newStudentID;
            string input;

            // Get student IDs and names 
            do
            {
                Console.WriteLine("Student ID: ");
                input = Console.ReadLine();

                if (!Equals(input, ""))
                {
                    newStudentID = int.Parse(input);
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    studentIDs.Add(newStudentID, name);

                    // Read in the newline before looping back
                    //Console.ReadLine();
                }

            } while (!Equals(input, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in studentIDs)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

        }
    }
}
