using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static double Multiply(double a,double b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2,3));
            Console.WriteLine(Multiply(3.4, 4.5));
            Console.ReadKey();
        }
    }
}
