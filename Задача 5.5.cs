using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Метод выполняет вывод заданного массива, размерами которые задает пользователь 
            Console.Write("Введите количество строк массива: \t");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: \t");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        a[i, j] = 0;
                    }
                    else
                    {
                        a[i, j] = 1;
                    }

                    Console.Write("{0,2} ", a[i, j]);

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
