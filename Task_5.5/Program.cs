using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целочисленное значение N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] array = new int[N,N];
            array[0, 0] = 1;
            for (int i = 1; i < N; i++)
            {
                if (array[i - 1, 0] == 1)
                {
                    array[i, 0] = 0;
                }
                else
                {
                    array[i, 0] = 1;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    if (array[i, j - 1] == 1)
                    {
                        array[i, j] = 0;
                    }
                    else
                    {
                        array[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,2}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
