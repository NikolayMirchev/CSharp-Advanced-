﻿using System;
using System.Linq;

namespace Problem_06._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            var number = int.Parse(Console.ReadLine());

            var list = arr
                .Where(x => x % number != 0)
                .ToList();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
