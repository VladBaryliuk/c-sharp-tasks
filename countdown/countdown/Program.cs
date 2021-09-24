using System;

namespace countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 0:
                    Console.WriteLine("one");
                    break;
                case 1:
                    Console.WriteLine("two");
                    break;
                case 2:
                    Console.WriteLine("three");
                    break;
                case 3:
                    Console.WriteLine("four");
                    break;
                case 4:
                    Console.WriteLine("five");
                    break;
                case 5:
                    Console.WriteLine("six");
                    break;
                case 6:
                    Console.WriteLine("seven");
                    break;
                case 7:
                    Console.WriteLine("eight");
                    break;
                case 8:
                    Console.WriteLine("nine");
                    break;
                case 9:
                    Console.WriteLine("ten");
                    break;
                case 10:
                    Console.WriteLine("one");
                    break;
                default:
                    Console.WriteLine("unknown number programme doesn't know the answer");
                    break;
            }
        }
    }
}
