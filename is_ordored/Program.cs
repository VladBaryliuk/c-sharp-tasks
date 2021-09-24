using System;

namespace is_ordored
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int increase = 0;
            int decrease = 0;
            for (int i = 0; i < array.Length; i ++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i+1])
                {
                    increase++;
                }
                else
                {
                    decrease++;
                }
            }
            if (increase == array.Length-1)
            {
                Console.WriteLine("increase");
            }
            else if (decrease == array.Length-1)
            {
                Console.WriteLine("decrease");
            }
            else
            {
                Console.WriteLine("unordored");
            }
        }
    }
}
