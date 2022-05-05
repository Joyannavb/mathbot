using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmatics
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multi(int num4, int num5)
        {
            return num4 * num5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to mathbot! let's do some math!");
            Console.WriteLine(" \r\n Give me a number.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number.");
            int num2 = int.Parse(Console.ReadLine());
            int sum = Add(num1,num2);
            Console.WriteLine($"Mathbot says those two numbers add up to equal {sum}!");

            Console.WriteLine("Let's do another one! Give me another number.");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me one more number!");
            int num4 = int.Parse(Console.ReadLine());
            int multi = Multi(num3, num4);
            Console.WriteLine($"Mathbot says when you multiply those numbers it equals {multi}.");


        }
    }
}
