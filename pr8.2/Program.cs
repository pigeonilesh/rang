using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Создайте квадратный массив");
            int stroka = 0;
            int stolbec = 0;
            do
            {
                Console.WriteLine($"Введите количество строк");
                stroka = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите количество столбцов");
                stolbec = Convert.ToInt32(Console.ReadLine());
            }
            while (stroka != stolbec);
            Random r = new Random();
            int[,] mas = new int[stroka, stolbec];
            for (int i = 0; i < stroka; i++)
            {
                for (int j = 0; j < stolbec; j++)
                {
                    mas[i, j] = r.Next(1, 101);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            int gl = 0;
            int pob = 0;
            for (int i = 0; i < stroka; i++)
            {
                for (int j = 0; j < stolbec; j++)
                {
                    if (i == j)
                    {
                        gl += mas[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумма главной диагонали: {gl}");
            for (int i = 0; i < stroka; i++)
            {
                pob += mas[i, stolbec - 1 - i];
            }
            Console.WriteLine($"Сумма побочной диагонали: {pob}");
        }
    }
}
