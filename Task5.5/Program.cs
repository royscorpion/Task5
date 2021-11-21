using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Формирование двумерного массива бинарных значений размером NxN, где N - задается пользователем, с контролем корректности введенного значения размерности массива
            #region Ввод исходных данных
            int N = 0;
            Console.Write("Задайте размерность массива: ");
            do
            {
                if ((N = Convert.ToInt32(Console.ReadLine()))<=0)
                    Console.Write("\nРазмерность массива должна задаваться целым положительным числом.\nПопробуйте еще раз: ");
            } while (N <= 0);
            #endregion

            #region Формирование массива с выводом результата
            int[,] array = new int[N, N];
            Console.WriteLine("Сформирован бинарный массив размерности {0}x{0}:", N);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = (i / 2 == (float)i / 2) ? ((j / 2 == (float)j / 2) ? 1 : 0) : ((j / 2 == (float)j / 2) ? 0 : 1);
                    Console.Write("{0,2} ", array[i, j]);
                }
                Console.WriteLine();
            }
            #endregion

            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
