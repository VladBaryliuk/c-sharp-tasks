using System;

namespace delete_the_number_from_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrray = new int[10];
            for (int y = 0; y < arrray.Length;y++)
            {
                arrray[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("----");
            int[] newArray = deleting(arrray);
            foreach (int j in newArray)
            {
                Console.WriteLine(j);
            }
        }
        static int[] deleting(int[] arrayFromWhatDelete)
        {
            int count = 0;
            int[] newArray = new int[10];
            for (int i = 0; i < arrayFromWhatDelete.Length;i++)
            {
                if(arrayFromWhatDelete[i] <= 10)
                {
                    newArray[count] = arrayFromWhatDelete[i];
                } 
                count++;
            }
            return newArray;
        }
    }
}

