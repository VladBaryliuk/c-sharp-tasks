using System;

namespace number_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string String = Console.ReadLine();
            Console.WriteLine(count_words(String));
        }
        static int count_words(string theString)
        {
            string[] array = theString.Split(" ");
            return array.Length;
        }
    }
}
