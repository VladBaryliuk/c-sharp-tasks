using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int [n,n];
            for (int j = 0; j < array.GetLength(0);j++)
            {
                for (int i = 0;i < n; i++)
                {
                    array[j,i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int m = Convert.ToInt32(Console.ReadLine());
            int index = m -1;
            for(int y = 0;y < n; y++)
            {
                for (int x = 0;x<n;x++)
                {
                    array[y,x] = array[y,x] * array[y,x]; 
                }
            }
            Console.WriteLine("----");
            for(int x = 0;x < 3; x++)
            {
                for(int y = 0;y < 3; y++)
                {
                    Console.Write(array[x,y]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
