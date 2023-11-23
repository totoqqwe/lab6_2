using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class MathOperations
    {
    public static T Add<T>(T a, T b)
        {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA + dynamicB;
        }

        public static T[] Add<T>(T[] arr1, T[] arr2)
        {
            if (arr1.Length != arr2.Length)
                throw new ArgumentException("Arrays must have the same length.");

            T[] result = new T[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = Add(arr1[i], arr2[i]);
            }
            return result;
        }

        public static T[,] Add<T>(T[,] matrix1, T[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);

            if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
                throw new ArgumentException("Matrices must have the same dimensions.");

            T[,] result = new T[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = Add(matrix1[i, j], matrix2[i, j]);
                }
            }
            return result;
        }
    }
}
