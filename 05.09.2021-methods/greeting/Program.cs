using System;

namespace greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            hello();
            goodbye();
        }
        static void hello()
        {
            Console.WriteLine("Hello");
        }
        static void goodbye()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
