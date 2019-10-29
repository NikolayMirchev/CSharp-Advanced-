using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var num in inputNumbers)
            {
                stack.Push(num);
            }

            string command = Console.ReadLine();
            while (command.ToLower() != "end")
            {
                string[] input = command.Split(" ").ToArray();
                if (input[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(input[1]));
                    stack.Push(int.Parse(input[2]));
                }
                else if (input[0].ToLower() == "remove")
                {
                    if (stack.Count > int.Parse(input[1]))
                    {
                        for (int i = 0; i < int.Parse(input[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine();
            }

            int totalSum = 0;
            while (stack.Count > 0)
            {
                totalSum += stack.Pop();
            }

            Console.WriteLine($"Sum: {totalSum}");
            
        }
    }
}
