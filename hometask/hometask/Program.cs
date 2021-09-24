using System;

namespace hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 numbers");
            Console.Write("enter the first number: ");
            string firstNumber = Console.ReadLine();
            Console.Write("enter the second number: ");
            string secondNumber = Console.ReadLine();
            Console.Write("enter the third number: ");
            string thirdNumber = Console.ReadLine();
            Console.Write("aaaaand   magic!");
            Console.Write("your number is ");
            Console.WriteLine(firstNumber + secondNumber + thirdNumber);
        }
    }
}
