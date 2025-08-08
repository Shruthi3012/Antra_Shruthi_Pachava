using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    internal static class Fibonacci
    {
      public static int FibonacciSeries(int n)
        {
            if(n == 1 || n == 2)
            {
                return 1;
            }
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
    }
}
