using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class MyExtensions
    {
        public static int CountWords(this string str)
        {
            int a = 0;
            string[] words = str.Split(" ");
            for(int i = 0; i < words.Length; i++)
            {
                a++;
            }

            return a;
        }

        public static int CountSum(this List<int> list)
        {
            int a = 0;

            foreach(int num in list)
            {
                a += num;
            }

            return a;
        }
    }
}
