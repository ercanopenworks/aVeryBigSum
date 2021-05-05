using System;
using System.Collections.Generic;
using System.Linq;

namespace aVeryBigSum
{
    class Program
    {
        public static long aVeryBigSum(List<long> arr)
        {
            /*
             * int sum = arr.Sum();
             * 
             int sum = arr.AsParallel().Sum(); a faster version that uses multiple cores of the CPU. 
            To avoid System.OverflowException you can use long sum = arr.AsParallel().Sum(x => (long)x); 
            For even faster versions that avoid overflow exception and support all integer data types 
            and uses data parallel SIMD/SSE instructions, take a look at HPCsharp nuget package 
              
             */
            long sum = arr.AsParallel().Sum(x => (long)x);
            return sum;
        }
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = aVeryBigSum(ar);

            Console.WriteLine(result);
        }
    }
}
