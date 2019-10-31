using System;

namespace _1._Generic_Box_of_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                var box = new Box<int>(num);

                Console.WriteLine(box.ToString());
            }
        }
    }
}
