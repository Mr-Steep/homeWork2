using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public static class Task2
    {
        public static void Lolo()
        {
            Console.WriteLine("Enter 6 number:");
            int N, a, b, c, d, e, f;
            N = int.Parse(Console.ReadLine());
            if (N < 999999 && N > 100000)
            {
                a = N % 10;
                b = N / 10 % 10;
                c = N / 100 % 10;
                d = N / 1000 % 10;
                e = N / 10000 % 10;
                f = N / 100000 % 10;

                if (a + b + c == d + e + f)
                {
                    Console.WriteLine("This is number a lucky");
                }
                else Console.WriteLine("Error");
            }
            else
                Console.WriteLine("Error, enter 6 numbers!");

        }

    }
}
