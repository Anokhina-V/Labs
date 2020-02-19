using System;

namespace практическая_работа_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int f = 10; f <= 99; f++)
            {
                bool flag = true;
                for (int i = 2; i <= 9; i++)
                {
                    int s = (f / 10) + (f % 10);
                    int s2 = (f * i / 100) + (f * i % 10) + (f * i % 100 / 10);
                    if (s != s2)
                    {
                        flag = false;
                    }
                }
                if (flag)
                    Console.WriteLine(f + ",");

            }
            Console.ReadLine();
        }
    }
}
