using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class RotateArray
    {
      public static void Sum()
        {
            Console.WriteLine("Size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter array elements : ");
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] sum = new int[n];
            Console.WriteLine("Enter rotaion: ");
            int r = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= r; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    int idx = (j + i) % n;
                    sum[idx] += a[j];
                }           
            }
            Console.WriteLine(string.Join(",", sum));
        }
    }
}
