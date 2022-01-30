using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Метод выполняет расчет ср.ариф. массива из введенных 7 чисел 
            Console.WriteLine("Введите массив из 7 чисел ");
            int [] array = new int[7];
            float Sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите элемент массива под индексом {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вывод одномерного массива");

            for (int i = 0 ; i < array.Length; i++)
            {
               Console.WriteLine("{0} ", array[i]);
                Sum += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифмитическое массива = {0} ", Sum/7);
            Console.ReadKey();
        }
    }
}
