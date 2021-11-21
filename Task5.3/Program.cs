using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Формирование одномерного массива из n=10 элементов, выбираемые рандомно из диапазона [-50,50], с упорядочиванием первых 5 элементов по возрастанию, вторых 5 - по убыванию
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            //Вывод рандомного одномерного массива
            Console.Write("Сформирован одномерный массив размерностью [{0}]: \n[ ",n);
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("]");
            //Сортировка первых 5 элементов по возрастанию
            for (int i = 0; i < n/2-1; i++)
            {
                for (int j = i + 1; j < n/2; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            //Сортировка вторых 5 элементов по убыванию
            for (int i = n/2; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            //Вывод упорядоченного массива
            Console.Write("Упорядоченный массив:\n[ ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("]");

            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}

