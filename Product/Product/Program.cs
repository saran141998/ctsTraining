using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            Console.WriteLine("Enter the first number");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            n2= float.Parse(Console.ReadLine());
            Console.WriteLine("The product of two numbers {0} and {1} is {2}", n1, n2, n1 * n2);
            Console.ReadKey();
        }
    }
}
