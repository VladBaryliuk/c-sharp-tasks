using System;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int[,] array = new int [2,2];
            for (int j = 0; j < 2;j++)
            {
                for (int i = 0;i < 2; i++)
                {
                    array[j,i] = Convert.ToInt32(Console.ReadLine());;
                    number += array[j,i];
                }
            }
            Console.WriteLine(number);

        }
    }
}
