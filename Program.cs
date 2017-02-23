/* C# program to check whether a given number is even or odd */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace check1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Console.Write("Please enter a number: ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered number is an even number!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Entered number is an odd number!");
                Console.ReadLine();
            }
        }
    }
}
