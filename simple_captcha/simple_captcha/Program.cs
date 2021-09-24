using System;

namespace simple_captcha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Are you robot?");
            string answer = Console.ReadLine();
            if (answer == "yes" || answer == "sure")
            {
                Console.WriteLine("hello robot!");
            }
            else if (answer == "no")
            {
                Console.WriteLine("congratulations, you passed the test!");
            }
            else
            {
                Console.WriteLine("I don't understand you");
            }
        }
    }
}
