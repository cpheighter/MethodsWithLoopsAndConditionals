using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static void Thousands()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void DivideByThirds()
        {
            for (int i = 3; i <= 999; i +=3)
            {
                Console.WriteLine(i);
            }
        }
        public static void EqualOrNot(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine($"{x} is equal to {y}");
            }
            else
            {
                Console.WriteLine($"{x} is not equal to {y}");
            }
                
        }
        public static void OddOrEven(int x)
        {
            if ((x % 2) == 0)
            {
                Console.WriteLine($"{x} is a even number");
            }
            else
            {
                Console.WriteLine($"{x} is a odd number");
            }
        }
        public static void PostiveOrNegative(int x)
        {
            if(x > 0)
            {
                Console.WriteLine($"{x} is a postive number");
            }
            else if(x < 0)
            {
                Console.WriteLine($"{x} is a negative number");
            }
            else
            {
                Console.WriteLine($"0 is neither postive or negative");
            }
        }
        public static void VoteAge()
        {
            Console.Write("Enter you age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You can VOTE!!!");
            }
            else
            {
                Console.WriteLine("You CANNOT vote.");
            }
        }


        //Method Practice
        //public static void Add(int x, int y)
        //{
        //    Console.WriteLine(x + y);
        //}
        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}
    }  
}
