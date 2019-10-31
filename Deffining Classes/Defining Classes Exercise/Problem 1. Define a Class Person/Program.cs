using System;
using System.Linq;

namespace Problem_1._Define_a_Class_Person
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split()
                    .ToArray();

                var name = tokens[0];
                var age = int.Parse(tokens[1]);

                var member = new Person(name, age);

                family.AddMember(member);
            }

            foreach (var name in family.Sort(family.People))
            {
                Console.WriteLine(name.ToString());
            }
        }
    }
}
