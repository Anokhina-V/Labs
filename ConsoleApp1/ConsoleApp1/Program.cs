using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение х");

            int x = Convert.ToInt32(Console.ReadLine());
            int y;

            if (x < 1)
            {
                y = 1 / x;
            }
            else if (x > 2)
            {
                y = 4;
            }
            else
            {
                y = x * x;
            }

            Console.WriteLine("f(x) = "+y);

        }
    }
}
