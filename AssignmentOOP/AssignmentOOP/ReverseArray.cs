using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    internal static class ReverseArray
    {
       public static int[] GenerateArray(int n)
        {
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = i+1;
            }
            return a;
        }

        public static void Reverse(int[] a)
        {
            int n = a.Length - 1;
            int i = 0;
            while(i <= n)
            {
                int temp = a[i];
                a[i] = a[n];
                a[n] = temp;
                i++;
                n--;
            }
        }

        public static void PrintNumbers(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
               Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }


    }
}
