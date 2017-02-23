using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num, reverse = 0;
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10; 
            }
            Console.WriteLine("The reverse of the entered number is: " +reverse);
            Console.ReadLine();
        }
    }
}
