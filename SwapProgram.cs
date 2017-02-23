using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("\n Enter your first number please: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter your second number please: ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = num1;
            Console.WriteLine("\n After swaping: ");
            Console.WriteLine("First number = " + num1);
            Console.WriteLine("Second number = " + num2);
            Console.Read();
        }
    }
}
