using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public static class Task1
    {
        public static void Lolo()
        {
            Console.WriteLine("Enter some symbols: ");
            char input;
            int spaceCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar;
     
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("Quantity of spaces: " + spaceCount);

        }
    }
}