using System;
using System.Collections.Generic;

namespace choosing_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            List<int> numbers = new List<int>();
            for (int i = 0; i < array.Length; i ++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
            }
            for (int y = 0; y < array.Length-1; y++)
            {
                if (array[y] >= 888)
                {
                    numbers.Add(array[y]);
                }
            }
            int[] chosenArray = new int[numbers.Count];

            int temp = 0;
            for (int y = 0; y < numbers.Count-1; y++)
            {
                for (int j = y + 1; j < numbers.Count; j++)
                {
                    if (numbers[y] < numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[y];
                        numbers[y] = temp;                        
                    }
                }
            }
            Console.WriteLine("------");
            chosenArray = numbers.ToArray();
            foreach (int x in chosenArray)
            {
                Console.WriteLine(x);
            }
        }
    }
}
