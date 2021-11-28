using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_HW
{
    class Program
    {

        static void Main(string[] args)
        {
            Сircle circle = new Сircle(60, 20, 15, 25, 100);
            circle.Clength();
            circle.Csquare();
            circle.Lies();

            Console.ReadKey();
            
        }

        class Сircle //static class Сircle

        {
            public double clength;
            public double csquare;
            public double lies;
            double R { get; set; }
            double X { get; set; }
            double X0 { get; set; }
            double Y { get; set; }
            double Y0 { get; set; }
            double l;

            public void Clength()  //public static void Clength()
            {
                clength = 2 * Math.PI * R;
                Console.WriteLine($"Длина окружности= {clength}");
            }

            public void Csquare() //public static void Csquare()
            {
                csquare = Math.PI * R * R;
                Console.WriteLine($"Площадь окружности= {csquare}");
            }

            public void Lies() //public static void Lies()
            {
                double l = Math.Sqrt((X0 - X) * (X0 - X) + (Y0 - Y) * (Y0 - Y));
                if (l <= R)
                    Console.WriteLine("Точка принадлежит кругу");
                else
                    Console.WriteLine("Точка не принадлежит кругу");
            }
            public Сircle(double x, double x0, double y, double y0, double r)
            {
                X = x;
                X0 = x0;
                Y = y;
                Y0 = y0;
                R = r;

            }
        }
    }
}

