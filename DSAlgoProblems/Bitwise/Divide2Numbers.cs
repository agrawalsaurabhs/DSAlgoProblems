using System;

namespace DSAlgoProblems.Bitwise
{
    class Divide2Numbers
    {
        static void Main1(string[] args)
        {
            int A = 0; int B = 1;
            var result = 0;
            if ((A > 0 && B > 0) || (A < 0 && B < 0))
            {
                result = Result(Math.Abs(A), Math.Abs(B));
            }
            else
            {
                result = -Result(Math.Abs(A), Math.Abs(B));
            }
            Console.WriteLine(result);
            Console.Read();
        }

        public static int Result(int A, int B)
        {
            if (B == 0) return int.MaxValue;
            if (B == -1 && A == int.MinValue)
                return int.MaxValue;
            if (A < B) { return 0; }
            int count = 0;
            while (A >= (B << count))
            {
                count++;
            }
            count = count - 1;
            return (1 << count) + Result(A - (B << count), B);
        }

    }
}
