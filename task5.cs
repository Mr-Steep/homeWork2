using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{

    public static class Task5
    {

        public static void Lolo()
        {
            Console.WriteLine("Enter Number");
            string s = Console.ReadLine();
            char[] str = s.ToCharArray(); ;
            string a;
            for (int i = str.Length - 1; i > -1; --i)
            {
                a = Convert.ToString(str[i]);
                Console.Write(a);
            }
            Console.WriteLine();
        }

    }
}
