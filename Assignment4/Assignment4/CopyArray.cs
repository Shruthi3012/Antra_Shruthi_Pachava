using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class CopyArray
    {
        public static void ArrayCopy()
        {
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = i + 1;
            }
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i]; 
            }
            for(int i = 0; i < 10; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for(int i = 0; i < 10; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
