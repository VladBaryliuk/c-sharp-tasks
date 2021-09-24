using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number of seconds: ");
            string second = Console.ReadLine();
            int seconds = Convert.ToInt32(second);
            Console.WriteLine($"In {seconds} seconds there are {seconds / 60} minutes and {seconds / 3600} hours");
        }
    }
}
