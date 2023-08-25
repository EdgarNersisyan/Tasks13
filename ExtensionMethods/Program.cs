using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create an extension method for the string class that counts the number of words in a sentence
            Create an extension method for the List<int> class that calculates the sum of all elements.*/

            string myString = "My name is Edgar";

            int count = myString.CountWords();

            Console.WriteLine($"The string <<{myString}>> contains {count} words");

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = list.CountSum();

            Console.WriteLine($"The sum of list's items is {sum}");

            Console.ReadLine();
        }
    }
}
