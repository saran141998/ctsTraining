using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Congratulations Mr/Miss {0} on your {1} birthday",name,age);
            Console.ReadKey();

        }
    }   
}
