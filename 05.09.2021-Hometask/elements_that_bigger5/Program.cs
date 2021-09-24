using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int [3,3];
            int[] newArray = new int [9];
            int count = 0;
            for (int j = 0; j < array.GetLength(0);j++)
            {
                for (int i = 0;i < array.GetLength(1); i++)
                {
                    array[j,i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int y = 0; y < array.GetLength(0);y++)
            {
                for(int x = 0;x < array.GetLength(1);x++)
                {
                    if(array[y,x] >= 5)
                    {
                        newArray[count] = array[y,x];
                        count++;
                    }
                }
            }
            Console.WriteLine("----");
            foreach(int e in newArray)
            {
                if (e != 0)
                {
                    Console.Write ($"{e} ");
                } 
            }
        }
    }
}
