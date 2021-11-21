using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Формирование одномерного массива из n=7 элементов, вводимых с клавиатуры, и определение среднего арифметического элементов массива
            #region Ввод исходных данных
            const int n = 7;
            int[] array = new int [n];
            float Sum = 0;
            Console.WriteLine("Введите последовательно {0} чисел",n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите элемент {0}: ",i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
                Sum += array[i];
            }
            #endregion

            Console.Write("Сформирован одномерный массив размерностью [{0}]: [ ",n);
            foreach (int a in array)
            {
                Console.Write("{0} ",a);
            }
            Console.WriteLine("]");
            Console.WriteLine("Среднее арифметическое элементов массива: {0:f3}",Sum/n);

            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}

