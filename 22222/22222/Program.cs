using System;

namespace _22222
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
         
            double n = Convert.ToDouble(Console.ReadLine());
            double x = 0;
            double a = 0;
            for ( double i=1; i<=n; i++)
            {
                x = (1.0 + (1.0 / (i * i)));
                a += x;
            }
            Console.WriteLine(a);
            Console.ReadLine();

        }
    }
}
