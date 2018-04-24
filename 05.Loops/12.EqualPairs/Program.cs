using System;

namespace _12.EqualPairs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] sum = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int number = int.Parse(Console.ReadLine());
                    sum[i] += number;
                }
            }

            int sumMax = int.MinValue;
            int sumMin = int.MaxValue;

            for (int i = 0; i < sum.Length; i++)
            {
                if  (sum[i] > sumMax)
                {
                    sumMax = sum[i];
                }

                if (sum[i] < sumMin)
                {
                    sumMin = sum[i];
                }
            }

            if(sumMin == sumMax)
            {
                Console.WriteLine($"Yes, value={sumMax}");
            }

            else
            {
                int maxDiff = int.MinValue;

                for (int i = 1; i < sum.Length; i++)
                {
                    if (Math.Abs(sum[i] - sum[i-1]) > maxDiff)
                    {
                        maxDiff = sum[i] - sum[i - 1];
                    }
                }
                Console.WriteLine("No, maxdiff={0}", Math.Abs(maxDiff));
            }
        }
    }
}
