using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class StringReverse
    {
   
      public static void reverse()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            char[] c = str.ToCharArray();
            int i = 0, j = str.Length-1;
            while(i <= j)
            {
                char c2 = c[i];
                c[i] = c[j];
                c[j] = c2;
                i++;
                j--;
            }
            string str1 = new string(c);
            Console.WriteLine("With char Array: " + str1);
            Console.Write("With string reverse: ");
            for ( i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
    }
}
