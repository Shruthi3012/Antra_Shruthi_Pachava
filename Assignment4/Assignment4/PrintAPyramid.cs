using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class PrintAPyramid
    {
       public static void Pyramid()
        {
            int n = 9;
            for(int i = 0; i <= n/2; i++)
            {
                for(int j = 0;  j < n/2 -i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = n/2 -i; j <= n/2 + i; j++)
                     Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
