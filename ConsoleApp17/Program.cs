using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 10;
            Console.WriteLine($"Addition of numbers: {MathOperations.Add(num1, num2)}");

            double[] arr1 = { 1.5, 2.5, 3.5 };
            double[] arr2 = { 0.5, 1.5, 2.5 };
            var resultArr = MathOperations.Add(arr1, arr2);
            Console.WriteLine($"Addition of arrays: [{string.Join(", ", resultArr)}]");

            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
            var resultMatrix = MathOperations.Add(matrix1, matrix2);
            Console.WriteLine("Addition of matrices:");
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write($"{resultMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
    }
}
