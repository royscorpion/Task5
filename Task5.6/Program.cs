using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Формирование двумерного массива размером NxN, где размерность N и числа массива задаются пользователем, с проверкой, является ли введенная матрица магическим квадратом
            #region Задание размерности массива
            int N = 0;
            Console.Write("Задайте размерность массива: ");
            do
            {
                if ((N = Convert.ToInt32(Console.ReadLine())) <= 0)
                    Console.Write("\nРазмерность массива должна задаваться целым положительным числом.\nПопробуйте еще раз: ");
            } while (N <= 0);
            #endregion

            #region Формирование массива с выводом результата
            int[,] array = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,4} ", array[i, j]);
                }
                Console.WriteLine();
            }
            #endregion

            #region Проверка: матрица - магический квадрат
            int M = N * (N * N + 1) / 2;
            bool magicSquare = true;
            for (int i = 0; i < N; i++)
            {
                int rowSum = 0, colSum = 0;
                for (int j = 0; j < N; j++)
                {
                    rowSum += array[i, j];
                    colSum += array[j, i];
                }
                Console.WriteLine("rowSum{0} = {1}, colSum{0} = {2}",N,rowSum,colSum );
                Console.WriteLine();
            }
            #endregion

            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
