using System;
using System.Collections.Generic;

namespace Problem_8.__Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();
            bool isBalanced = true;
            bool turn = false;

            foreach (var character in input)
            {
                if (character == '{' || character == '(' || character == '[' || character == ' ' && !turn)
                {
                    stack.Push(character);
                }
                else if (character == '}' || character == ')' || character == ']' || character == ' ')
                {
                    turn = true;
                    if (character == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else if (character == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else if (character == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else if (character == ' ' && stack.Peek() == ' ')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
