using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] mas = new string[3, 3];
            string[] kn = {"X", "O", "_"};
            Random r = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = kn[r.Next(0, 3)];
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            string letter = "_";
            for (int i = 0; i < 3; i++)
            {
                if (mas[i, 0] != "_" && mas[i, 0] == mas[i, 1] && mas[i, 1] == mas[i, 2])
                {
                    letter = mas[i, 0];
                }
                if (mas[0, i] != "_" && mas[0, i] == mas[1, i] && mas[1, i] == mas[2, i])
                {
                    letter = mas[0, i];
                } 
            }
            if (mas[0, 0] != "_" && mas[0, 0] == mas[1, 1] && mas[1, 1] == mas[2, 2])
            {
                letter = mas[0, 0];
            }
            if (mas[0, 2] != "_" && mas[0, 2] == mas[1, 1] && mas[1, 1] == mas[2, 0])
            {
                letter = mas[0, 2];
            }
            Console.WriteLine(letter == "X" ? "Победели крестики" : letter == "O" ? "Победили нолики" : "Нет побидителей");
        }
    }
}
