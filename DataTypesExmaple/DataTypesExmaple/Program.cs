using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesExmaple
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 23;
            short s = 32000;
            int n = 999;
            uint m = 429456;
            Console.WriteLine("8-bit unsigned integer ranges from 0 to 255 {0} is within range",b);
            Console.WriteLine("16-bit signed integer ranges from -32,768 to 32,767 {0} is within range",s);
            Console.WriteLine("32-bit signed integer ranges from -2,147,483,648 to 2,147,483,647 {0} is within range",n);
            Console.WriteLine("32-bit unsigned integer ranges from 0 to 4,294,967,295 {0} within range",m);
            Console.WriteLine("32-bit unsigned integer ranges from ");
            Console.WriteLine("32-bit unsigned integer ranges from ");
            Console.ReadKey();
        }
    }
}
