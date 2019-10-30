using System;
using System.Collections.Generic;

namespace _7._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> guests = new SortedSet<string>();

            var entry = Console.ReadLine();

            while (entry?.ToLower() != "party")
            {
                guests.Add(entry);

                entry = Console.ReadLine();
            }

            entry = Console.ReadLine();
            while (entry?.ToLower() != "end")
            {
                guests.Remove(entry);

                entry = Console.ReadLine();
            }
            Console.WriteLine(guests.Count);

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
