using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8._3
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
            Console.WriteLine();
            int[,] mast = new int[stolbec, stroka]; 
            for (int i = 0; i < stolbec; i++)
            {
                for (int j = 0; j < stroka; j++)
                {
                    mast[i, j] = mas[j, i];
                    Console.Write(mast[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
