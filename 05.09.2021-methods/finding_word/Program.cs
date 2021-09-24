using System;

namespace finding_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToFindWord = Console.ReadLine();
            string WordToFind = Console.ReadLine();
            Console.WriteLine(finding(stringToFindWord, WordToFind));
        }
        static bool finding(string theString,string theWord)
        {
            string[] array = theString.Split(" ");
            foreach (string i in array)
            {
                if (i == theWord)
                {
                    return true;
                }
            }
            return false; 
        }
    }
}
