using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    //    Числовые значения символов нижнего регистра в коде ASCII
    //отличаются от значений символов верхнего регистра на
    //величину 32. Используя эту информацию, написать про-
    //грамму, которая считывает с клавиатуры и конвертирует
    //Домашнее задание №1 все символы нижнего регистра в символы верхнего ре-
    //гистра и наоборот.
    public static class Task3
    {
        public static void Lolo()
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            char[] new_str = str.ToCharArray();
            for (int i = 0; i < new_str.Length; i++)
            {
                int A_new_str = (int)new_str[i];

                if (A_new_str > 65 && A_new_str < 90)
                {
                    char c = new_str[i];
                    char Small = char.ToLower(c);
                    Console.Write(Small);
                }

                else if (A_new_str > 97 && A_new_str < 122)
                {
                    char v = new_str[i];
                    char Big = char.ToUpper(v);
                    Console.Write(Big);
                }

            }
            Console.WriteLine();
        }

    }
}
    