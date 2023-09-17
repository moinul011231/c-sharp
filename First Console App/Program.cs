using System;

namespace First_Console_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name: ");
            var TakeName = Console.ReadLine();
            Console.WriteLine("Hello, "+ TakeName);
            Console.WriteLine("Please Enter your password: ");
            var password = Console.ReadLine();
            Console.WriteLine("password , " + password);
        }
    }
}