using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {1, 2, 3},
                {5, 6, 7}
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                { 
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            foreach (var i in matrix)
            {
                Console.Write(i + " ");
            }
        }
    }
}
