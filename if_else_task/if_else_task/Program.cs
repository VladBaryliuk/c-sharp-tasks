using System;

namespace if_else_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("+");
            }
            else if (number < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
