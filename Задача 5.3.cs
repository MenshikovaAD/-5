using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Метод упорядочивает 5 чисел по убыванию, 5 чисел по возрастанию массива из 10 чисел 
            int[] array1 = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                array1[i] = random.Next(-50, 50);
                Console.Write("{0} ", array1[i]);
            }
            Console.WriteLine(Environment.NewLine);

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array1[i] > array1[j])
                    {
                        int t = array1[i];
                        array1[i] = array1[j];
                        array1[j] = t;
                    }

                }
            }
            for (int i = 5; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array1[i] < array1[j])
                    {
                        int t = array1[i];
                        array1[i] = array1[j];
                        array1[j] = t;
                    }
                }
        
            }
            Console.WriteLine(Environment.NewLine);
            

            Console.ReadKey();
        }
    }
}
