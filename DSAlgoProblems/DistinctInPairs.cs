using System;
using System.Collections.Generic;

namespace DSAlgoProblems
{
    class DistinctInPairs
    {
        static void Main2(string[] args)
        {
            var number = singleNumber(new List<int> { 1, 2, 2, 3, 1 });
            Console.WriteLine(number);
            Console.Read();
        }

        public static int singleNumber(List<int> A)
        {
            if(A.Count ==0)
            {
                throw new Exception("Empty Array");
            }
           A.Sort();
            for(int i=0;i<A.Count;i++)
            {
                if(i==A.Count-1)
                {
                    return A[i];
                }
                if((A[i] ^ A[i+1] )== 0)
                {
                    i++;
                }
                else
                {
                    return A[i];
                }
                
            }
            throw new Exception("No duplicate element found");
        }
    }
}
