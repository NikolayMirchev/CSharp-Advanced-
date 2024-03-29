﻿using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                jaggedArray[i] = numbers;
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()?.ToLower()) != "end")
            {
                string[] tokens = command
                    .Split();
                string operations = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 
                    || row >= rows 
                    || col < 0 
                    || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalide coordinates");
                    continue;
                }

                switch (operations)
                {
                    case "add":
                        jaggedArray[row][col] += value;
                        break;
                    case "subtract":
                        jaggedArray[row][col] -= value;
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
