using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class LongestSquence
    {
       public static void LongestSequenceCount()
        {
            Console.WriteLine("Enter the array size: ");

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array Elements : ");
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i]  = Convert.ToInt32(Console.ReadLine());

            }
            int currCount = 1, ans = a[0], count = 1;
            for(int i = 1; i < n; i++)
            {
                if (a[i] == a[i - 1])
                    currCount++;
                else
                {
                    if(count < currCount)
                    {
                        count = currCount;
                        ans = a[i - 1];
                    }
                    currCount = 1;

                }
            }
            if (count < currCount)
            {
                count = currCount;
                ans = a[n - 1];
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(ans + " ");
            }
            Console.WriteLine();
        }
    }
}
