using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            square(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
        }
        static void square(int number1, int number2)
        {
            int squareNumber = number1 * number2;
            Console.WriteLine(squareNumber);
        }
    }
}
