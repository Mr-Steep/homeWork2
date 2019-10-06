using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{


    // Канцелярский товар 
    public class StationaryPen
    {
        public string NamePen = "SupePen";
        int weight = 15;
        private string firm = "Pilot";
        private string color = "Black";
        private bool autoPen = true;
        private double kernelPen = 1500; //cv пишет ручка
        private static int kolpach;
        private static string name;


        static double somestaticfield;

        static StationaryPen()// Статический конструктор имеет то же имя , что и класс в котором он определен.
        {
            // Инициализируем статические поля класса.
            somestaticfield = 99.99;
        }


        public StationaryPen()
        {


        }
        public StationaryPen(string NamePen)
        {

            this.NamePen = NamePen;
        }
        public StationaryPen(string NamePen, string color)
        {

            this.NamePen = NamePen;
            this.color = color;
        }





        static void Hello_Pen()
        {
            Console.WriteLine("Hello i am Pen");
        }

        void Character_Pen()
        {

            Console.Write("Weihht", weight, "\n Firm = ", firm, "\n Color = ", color, "\n KernelPen on  = ", kernelPen, " m");
        }

        public double WritePen_1m()
        {

            return kernelPen - 100;
        }

        public double WritePen_1m(double g)
        {

            return kernelPen - 100 - g;
        }


        public string change_color_pen(string new_color)
        {
            return color = new_color;
        }

        // передача по ссылке 

        public double Write_Pen_2m(ref double x, double write)
        {
            return x -= write;
        }


      
    }
}