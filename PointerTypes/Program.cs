using System;

namespace PointerTypes
{
    class Program
    {
        static unsafe void ReverseString(char* start, int length)
        {
            char* pLeft = start;
            char* pRight = start + length - 1;

            while (pLeft < pRight)
            {
                char temp = *pLeft;
                *pLeft = *pRight;
                *pRight = temp;

                pLeft++;
                pRight--;
            }
        }

        static unsafe void Swap(int* a, int* b)
        {
            int temp = *a;
            *a = *b;
            *b = temp;
        }

        static unsafe void Main(string[] args)
        {
            /*Create a program that uses pointers to reverse the characters in a string.
            Create a program that uses pointers to swap the values of two integers*/

            string myStr = "Hello, World!";
            char[] charArray = myStr.ToCharArray();

            Console.WriteLine($"Before: {myStr}");

            fixed (char* charPtr = charArray)
            {
                ReverseString(charPtr, charArray.Length);
            }

            string reversed = new string(charArray);
            Console.WriteLine($"After: {reversed}");


            int num1 = 5;
            int num2 = 10;

            Console.WriteLine($"Before: num1 = {num1}, num2 = {num2}");
            Swap(&num1, &num2);
            Console.WriteLine($"After: num1 = {num1}, num2 = {num2}");
            
        }
    }
}
