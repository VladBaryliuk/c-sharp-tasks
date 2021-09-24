using System;

namespace sum_of_two_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int [3,3];
            int[,] array2 = new int [3,3];
            int[,] array3 = new int [3,3];
            for (int j = 0; j < 3;j++)
            {
                for (int i = 0;i < 3; i++)
                {
                    array[j,i] = Convert.ToInt32(Console.ReadLine());;
                }
            }
            Console.WriteLine("-----First array sucsecfully created-----");
            for (int j = 0; j < 3;j++)
            {
                for (int i = 0;i < 3; i++)
                {
                    array2[j,i] = Convert.ToInt32(Console.ReadLine());;
                }
            }
            Console.WriteLine("Counting the sum.....");
            for (int j = 0; j < 3;j++)
            {
                for (int i = 0;i < 3; i++)
                {
                    array3[j,i] = array[j,i] + array2[j,i]; 
                }
            }
            foreach(int x in array3)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("----The result----");
        }
    }
}
