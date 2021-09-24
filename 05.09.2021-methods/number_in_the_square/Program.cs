using System;

namespace number_in_the_square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(square(Convert.ToInt32(Console.ReadLine())));   
        }
        static int square(int number)
        {
            return number * number;
        }
    }
}
