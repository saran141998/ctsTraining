using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateChallenge
{


class Program
    {

        public static double areaTriangle(double b, double h)
        {

            return (1 * b * h) / 2;
        }
        public static double areaRect(double len, double breadth)
        {

            return len * breadth;
        }
        static void Main(string[] args)
        {
            Func<double, double, double> area = areaTriangle;
            Console.WriteLine("Area of triangle is: {0}", areaTriangle(2, 2));
            area = areaRect;
            Console.WriteLine("Area of Rectangle is: {0}", areaRect(2, 2));
            Console.ReadKey();
        }
    }
}
