using System;
using System.Collections.Generic;

namespace DSAlgoProblems.Bitwise
{
    class Palindrome
    {
        static void Main4(string[] args)
        {
            
            Console.WriteLine(isPalindrome("A man, a plan, a canal: Panama"));
            Console.Read();
        }

        public static int isPalindrome(string A)
        {
            int i = 0;
            int j = A.Length-1;

            while (i != j)
            {
                if (!((A[i] >= 'A' && A[i] <= 'Z') || (A[i] >= 'a' && A[i] <= 'z') || (A[i] >= '0' && A[i] <= '9')))
                {
                    i++;
                    continue;
                }

                if (!((A[j] >= 'A' && A[j] <= 'Z') || (A[j] >= 'a' && A[j] <= 'z') || (A[j] >= '0' && A[j] <= '9')))
                {
                    j--;
                    continue;
                }



                if (char.ToLower(A[i]) == char.ToLower(A[j]))
                {
                    i++;
                    j--;
                }
                else
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
