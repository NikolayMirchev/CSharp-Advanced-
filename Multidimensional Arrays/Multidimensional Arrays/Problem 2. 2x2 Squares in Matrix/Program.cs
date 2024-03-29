﻿using System;
using System.Linq;

namespace Problem_2._2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            var matrixSize = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var matrix = new char[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputRow = Console.ReadLine()
                    .Split()
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            int counterEqualMatrix2x2 = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col]
                        && matrix[row + 1, col] == matrix[row, col + 1]
                        && matrix[row, col + 1] == matrix[row + 1, col + 1])
                    {
                        counterEqualMatrix2x2++;
                    }
                }
            }

            Console.WriteLine(counterEqualMatrix2x2);
        }
    }
}
