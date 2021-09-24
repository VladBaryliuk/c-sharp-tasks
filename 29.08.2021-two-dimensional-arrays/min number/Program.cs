using System;

namespace min_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int min_n = 0;
            int min_m = 0;
            int[,] array = new int [n,m];
            for (int j = 0; j < n;j++)
            {
                for (int i = 0;i < m; i++)
                {
                    array[j,i] = Convert.ToInt32(Console.ReadLine());;
                }
            }
            int min = array[0,0];
            for (int y = 0; y < n; y++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[y,j] < min)
                    {
                        min = array[y,j];                      
                    }
                    min_n = y;
                    min_m = j;
                }
            }
            Console.WriteLine("-----");
            Console.WriteLine(min);
            Console.WriteLine($"n:{min_n}");
            Console.WriteLine($"n:{min_m}");

        }
    }
}
