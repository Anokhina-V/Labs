using System;

namespace _777
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите количество строк : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int x = 0;
            int[] M = new int[m];
            int[] N = new int[n];
            int[] M1 = new int[m];
            int[] N1 = new int[n];
            Random r = new Random();
            int[,] mas = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = r.Next(100);
                    Console.Write(mas[i, j] + " ");
                }
            }
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                max = min = mas[i, 0];
                for (int j = 1; j < m; j++)
                {
                    x = mas[i, j];
                    if (x < min) min = x;
                    if (x > max) max = x;
                }
                N[i] = max;
                N1[i] = min;
            }

            for (int j = 0; j < m; j++)
            {
                max = min = mas[0, j];
                for (int i = 1; i < n; i++)
                {
                    x = mas[i, j];
                    if (x < min) min = x;
                    if (x > max) max = x;
                }
                M[j] = max;
                M1[j] = min;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] == M[j] && mas[i, j] == N1[i] || mas[i, j] == M1[j] && mas[i, j] == N[i])
                    {
                        Console.WriteLine("sedlovaya tochka in point ({0}, {1}) = {2}", i, j, mas[i, j]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
