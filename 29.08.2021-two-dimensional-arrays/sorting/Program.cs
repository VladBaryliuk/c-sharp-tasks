using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int [3,3];
            for (int j = 0; j < 3;j++)
            {
                for (int i = 0;i < 3; i++)
                {
                    array[j,i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int m = Convert.ToInt32(Console.ReadLine());
            int index = m -1;
            int temp = 0;
            bool sorted = false;
            while(!sorted)
            {
                sorted = true;
                for (int j = 0; j < array.GetLength(0)-1; j++)
                {
                    if (array[j, index] > array[j+1, index])
                        {
                            temp = array[j,index];
                            array[j,index] = array[j+1,index];
                            array[j+1,index] = temp;
                            sorted = false;                        
                        }
                }
            }
            Console.WriteLine("----");
            for(int x = 0;x < 3; x++)
            {
                for(int y = 0;y < 3; y++)
                {
                    Console.Write(array[x,y]);
                }
                Console.WriteLine();
            }

        }
    }
}
