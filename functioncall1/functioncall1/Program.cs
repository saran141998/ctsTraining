using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functioncall1
{
    class Program
    {
        public static string greetings(string name,int age1)
        {

			return string.Format("Welcome Mr." + name + "your age is " + age1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine(greetings("Saravanan",23));
            Console.ReadKey();
            
        }

       
    }
}
