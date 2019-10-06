using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork2
{
    
    class Program
    { 
        static void Main(string[] args)
        {
            //Task1.Lolo();
            //Task2.Lolo();
            //Task3.Lolo();
            //Task4.Lolo();
            //Task5.Lolo();
            double x = 200;
            double y = 29;

            StationaryPen hgv = new StationaryPen();
           
           ///Console.WriteLine(hgv.WritePen_1m());
            Console.WriteLine(hgv.Write_Pen_2m(ref x, y));
            Console.WriteLine(hgv.WritePen_1m(56));// перегруженный метод 

            StationaryPen value1 = new StationaryPen();
            StationaryPen value2 = new StationaryPen("SuperMaxPen");
            StationaryPen value3 = new StationaryPen("SuperMaxPen2", "yellow");


            StationaryPen[] mass= new StationaryPen[5];


            for (int i = 0; i < 5; i++)
            {
                mass[i] = new StationaryPen();
            }


            PartialProver lol = new PartialProver();

            lol.HAM();
            lol.kol();



        }
    } 
}
