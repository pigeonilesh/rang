using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stroka = 0;
            int stolbec = 0;
            Console.WriteLine($"Введите количество строк");
            stroka = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество столбцов");
            stolbec = Convert.ToInt32(Console.ReadLine());
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
            int kol = 0;
            for (int i = 0; i < stroka; i++)
            {
                int min = mas[i, 0];
                int mini = 0;
                for (int j = 0; j < stolbec; j++)
                {
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                        mini = j;
                    }
                }
                int max = mas[0, mini];
                int maxi = 0;
                for (int k = 0; k < stroka; k++)
                {
                    if (mas[k, mini] > max)
                    {
                        max = mas[k, mini];
                        maxi = k;
                    }
                }
                int sedl = min;
                if (max == min)
                {
                    kol++;
                    Console.WriteLine($"{kol}. [{maxi + 1},{mini + 1}] = {sedl}");
                }
            }
            if (kol == 0)
            {
                Console.WriteLine($"Седловых точек нет");
            }
        }
    }
}
