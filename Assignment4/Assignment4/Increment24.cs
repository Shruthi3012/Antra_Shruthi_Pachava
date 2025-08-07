using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class Increment24
    {
      public static void CountIncrement24()
        {
            for(int i = 0; i <= 24; i++ )
                 Console.Write( i  + " ");
            Console.WriteLine();
            for(int i = 0; i <= 24; i = i+2)
                Console.Write( i + " ");
            Console.WriteLine();
            for (int i = 0; i <= 24; i = i + 3)
                Console.Write(i + " ");
            Console.WriteLine();
            for (int i = 0; i <= 24; i = i + 4)
                Console.Write(i + " ");
            Console.WriteLine();

        }
    }
}
