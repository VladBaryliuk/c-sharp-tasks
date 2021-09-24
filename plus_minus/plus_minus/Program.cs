using System;

namespace plus_minus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number please: ");
            try
            {
                double number = Convert.ToDouble(Console.ReadLine());
                if (number > 0)
                {
                    Console.WriteLine("+");
                }
                else if (number < 0)
                {
                    Console.WriteLine("-");
                }
                else if (number == 0)
                {
                    Console.WriteLine("0");
                }
            } 
            catch
            {
                Console.WriteLine("Programme doesn't understand");
            }
        }
    }
}
