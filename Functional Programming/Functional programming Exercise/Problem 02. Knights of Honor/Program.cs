using System;
using System.Linq;

namespace Problem_02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string> print = p => Console.WriteLine($"Sir {p}");

            foreach (var name in input)
            {
                print(name);
            }
        }
    }
}
