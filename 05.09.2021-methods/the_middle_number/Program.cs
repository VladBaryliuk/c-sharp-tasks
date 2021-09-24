using System;

namespace the_middle_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers_array = new int[10];
            for (int i = 0;i < numbers_array.Length;i++)
            {
                numbers_array[i] = Convert.ToInt32(Console.ReadLine());
            }
            middle(numbers_array); 
        }
        static void middle(int[] numbers)
        {
            double count = 0;
            for (int j = 0;j <numbers.Length;j++)
            {
                count += numbers[j];
            }
            double middleNumber = count / numbers.Length;
            Console.WriteLine(middleNumber);
        }
    }
}
