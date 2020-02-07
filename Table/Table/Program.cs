using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class Program
    {
        enum medics
        {
            amoxycillin=5,
            azothromycin,
            paracetomol=4
        }
        public static void Mul()
        {
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);

            }
        }
        public static void ifelse()
        {
            int a = 10, b = 2, c = 3;
            if(a>b && a > c)
            {
                Console.WriteLine("A is greater");
            }
            else if (b > c)
            {
                Console.WriteLine("B is greater");

            }
            else
            {
                Console.WriteLine("C is greater");
            }
        }
        public static void whileDemo()
        {
            int rem = 0, sum = 0;
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            Console.WriteLine("The Sum of the digits {0} is {1}",n,sum);

        }
        public static void enumdemo()
        {
            Console.WriteLine((int)medics.amoxycillin);
            Console.WriteLine((int)medics.azothromycin);
        }
        public static void greetings(string name ,int age)
        {
            Console.WriteLine("Welcome Mr.{0} your age is {1}",name,age);
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a Choice 1.ForDemo 2.ifelseDemo 3.whileDemo 4.enumdemo 5.FunctionCall");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "ForDemo":
                    Mul();
                    break;
                case "ifelseDemo":
                    ifelse();
                    break;
                case "whileDemo":
                    whileDemo();
                    break;
                case "enumdemo":
                    enumdemo();
                    break;
                case "FunctionCall":
                    greetings("Saravanan",23);
                    break;
                default:
                    Console.WriteLine("please select the correct choice");
                    break;

            }
            Console.ReadKey();
        }
    }
}
