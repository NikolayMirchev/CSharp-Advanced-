using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = 0;

            Dictionary<string, List<double>> students =
                new Dictionary<string, List<double>>();

            numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                var entry = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (students.ContainsKey(entry[0]))
                {
                    students[entry[0]].Add(double.Parse(entry[1]));
                }
                else
                {
                    students[entry[0]] = new List<double>()
                    {
                        double.Parse(entry[1])
                    };
                }
            }

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {String.Join(" ", item.Value)} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
