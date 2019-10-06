using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
 
    public static class Task4
    {
      
        public static void Lolo()
        {
            Console.WriteLine("Enter A: ");
            int a = int.Parse(Console.ReadLine());
            int s = a;
            Console.WriteLine("Enter B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (a <= b)
            {
                for (int i = 1; i <= a; i++)
                    Console.Write("{0}", a);
                a++;
                Console.WriteLine();
            }
            Console.ReadKey();

        }

    }
}
