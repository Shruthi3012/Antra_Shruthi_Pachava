using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class PrimeNumbers
    {
        public static int[] PrimeList(int startNum, int endNum)
        {
            List<int> list = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                int count = 0;
                if (i == 1)
                    count = 1;
                else if(i == 2)
                {
                    list.Add(i);
                    continue;
                }
                else if (i % 2 == 0)
                    count = 1;
                else
                {
                    for (int j = 3; j * j <= i; j +=2 )
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                        list.Add(i);
                }
                
            }
            return list.ToArray();
        }
    }
}
