using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Формирование одномерного массива из n=20 элементов, выбираемые рандомно из диапазона [-50,50], с определением количества нечетных положительных элементов, стоящих на четных местах.
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            int oddNum = 0;
            //Вывод рандомного одномерного массива
            Console.Write("Сформирован одномерный массив размерностью [{0}]: \n[ ", n);
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("]");
            //Определение кол-ва нечетных положительных чисел, стоящих на четных местах
            for (int i = 1; i < n ; i+=2)
            {
                if (array[i] / 2 != (float)array[i] / 2 && array[i]>0)
                    oddNum++;
            }
            Console.WriteLine("Количество нечетных положительных чисел, стоящих на четных местах: {0}",oddNum);

            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}

