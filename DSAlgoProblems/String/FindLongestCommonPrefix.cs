using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAlgoProblems.Bitwise
{
    class FindLongestCommonPrefix
    {
        static void Main(string[] args)
        {
            var input = new List<string>()
            {
                "ABCD",
            };
            Console.WriteLine(LongestCommonPrefix(input));
            Console.Read();
        }

        public static string LongestCommonPrefix(List<string> A)
        {
            StringBuilder s = new StringBuilder();
            if (A.Any(x => x.Length == 0))
            {
                return s.ToString();
            }

            bool cont = true;
            int i = 0;
            while (cont)
            {
                //stop when any string's end is reached
                if (A.Any(x => x.Length == i))
                {
                    cont = false;
                    break;
                }

                //this means all the string have some element at ith position

                char nextChar = A.First()[i];
                foreach (var item in A)
                {
                    if (item[i] == nextChar)
                    {
                        continue;
                    }

                    cont = false;
                    break;
                }

                if (cont)
                {
                    i++;
                    s.Append(nextChar);
                }
            }

            return s.ToString();
        }
    }
}
