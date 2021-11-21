using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Формирование одномерного массива из n=15 элементов, выбираемые рандомно из диапазона 0-50, и определение максимального и минимального элементов массива
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            int min, max;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
            }
            Console.Write("Сформирован одномерный массив размерностью [{0}]: \n[ ", n);
            max = min = array[0];
            foreach (int a in array)
            {
                Console.Write("{0} ", a);
                if (max < a) max = a;
                if (min > a) min = a;
            }
            Console.WriteLine("]");
            Console.WriteLine("Максимальный элемент массива: {0}\nМинимальный элемент массива: {1}", max, min);

            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}

