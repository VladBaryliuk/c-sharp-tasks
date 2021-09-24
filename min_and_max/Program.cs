using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i ++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
            }
            int temp = 0;
            for (int y = 0; y < array.Length-1; y++)
            {
                for (int j = y + 1; j < array.Length; j++)
                {
                    if (array[y] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[y];
                        array[y] = temp;                        
                    }
                }
            }
            int differens = array[array.Length -1] - array[0];
            Console.WriteLine("------");
            Console.WriteLine(differens);
        }
    }
}
