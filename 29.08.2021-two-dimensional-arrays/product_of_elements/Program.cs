using System;

namespace product_of_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int[,] array = new int [3,3];
            for (int j = 0; j < 3;j++)
            {
                for (int i = 0;i < 3; i++)
                {
                    array[j,i] = Convert.ToInt32(Console.ReadLine());
                    if (array[j,i] % 3 != 0)
                    {
                        number *= array[j,i];
                    }
                }
            }
            Console.WriteLine("------");
            Console.WriteLine(number);
        }
    }
}
