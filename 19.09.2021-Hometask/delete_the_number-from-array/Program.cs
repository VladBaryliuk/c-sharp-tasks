using System;

namespace delete_the_number_from_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrray = new int[5];
            for (int y = 0; y < arrray.Length;y++)
            {
                arrray[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("----");
            int numberToDelete = Convert.ToInt32(Console.ReadLine());
            int[] newArray = deleting(arrray,numberToDelete);
            Console.WriteLine("----");
            foreach (int j in newArray)
            {
                if (j != 0)
                {
                    Console.WriteLine(j);
                }
            }
        }
        static int[] deleting(int[] arrayFromWhatDelete,int number)
        {
            int count = 0;
            int[] newArray = new int[5];
            for (int i = 0; i < arrayFromWhatDelete.Length;i++)
            {
                if(arrayFromWhatDelete[i] != number)
                {
                    newArray[count] = arrayFromWhatDelete[i];
                }
                count++;
            }
            return newArray;
        }
    }
}
