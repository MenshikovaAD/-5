using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Метод выполняет расчет суммы max и min числа массива из 15 чисел 
            int  [] array = new int [15];
            Random random = new Random();
            float Sum = 0;
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0,50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine(Environment.NewLine);
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max) 
                max = a;
            }
            Console.WriteLine("Максимальное число массива = {0} ", max);
            int min = array[0];
            foreach (int a in array)
            {
                if (a < min) 
                min = a;
            }
            Console.WriteLine("Минимальное число массива = {0} ", min);
            Sum = max + min;

            Console.WriteLine();
            Console.WriteLine("Сумма max и min чисел массива = {0} ", Sum);
            Console.ReadKey();
        }
    }
}
