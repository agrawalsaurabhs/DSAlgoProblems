using System;
using System.Collections.Generic;

namespace DSAlgoProblems
{
    class DistinctInTriplets
    {
        static void Main(string[] args)
        {
            var number = singleNumber(new List<int> { 1, 2, 2, 2, 14,14,14,7, 1 ,1,9,9,9});
            Console.WriteLine(number);
            Console.Read();
        }

        public static int singleNumber(List<int> A)
        {
            if(A.Count ==0)
            {
                throw new Exception("Empty Array");
            }
            int result = 0;
            for(int i=0;i<32;i++)
            {
                //find ith bit of the number
                int sum = 0;
                foreach (var item in A)
                {
                    var iThBit = ((1 << i) & item) >= 1 ? 1 : 0;
                    sum += iThBit;
                }
                if(sum%3!=0)
                {
                    result = result | (1 << i);
                }
             
            }
            return result;



            throw new Exception("No duplicate element found");
        }
    }
}
