using System;
using System.Linq;

namespace SumofBiggestNeighbor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer to question 1. Sum of Biggest Neighbors\n");
            ISolver solver = new Solver();
            Run(solver);
        }

        private static void Run(ISolver solver)
        {
            Console.WriteLine("Enter the comma separated values of array\nor \"quit\" to quit.");
            var command = Console.ReadLine();
            while (command.ToLower() != "quit")
            {
                int[] inputArray;
                try
                {
                    inputArray = command.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                }
                catch
                {
                    Console.WriteLine("The input is invalid. Please try again.");
                    command = Console.ReadLine();
                    continue;
                }
                var result = solver.Challenge(inputArray);
                Console.WriteLine($"The result of sum of biggest neighbors is: {result}");
                Console.WriteLine("\n\nEnter another set of values\nor \"quit\" to quit.");
                command = Console.ReadLine();
            }
        }
    }
}
