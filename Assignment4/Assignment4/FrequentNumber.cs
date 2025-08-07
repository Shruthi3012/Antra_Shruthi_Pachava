using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class FrequentNumber
    {
       public static void MostFrequentNumber()
        {
            Console.WriteLine("Enter the array size: ");

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array Elements : ");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Dictionary<int, int> freqDict = new Dictionary<int, int>();
            Dictionary<int, int> indexDict = new Dictionary<int, int>();
            for(int i = 0; i < n; i++)
            {
                if(freqDict.ContainsKey(a[i]))
                    freqDict[a[i]]++;
                else
                    freqDict.Add(a[i], 1);
                if(!indexDict.ContainsKey(a[i]))
                    indexDict.Add(a[i], i);
            }

            int maxCount = 0, ans = 0, idx = 0;
            foreach(int i in freqDict.Keys)
            {
                if (freqDict[i]  > maxCount || (freqDict[i] == maxCount && indexDict[i] < idx))
                {
                    maxCount = freqDict[i];
                    ans = i;
                    idx = indexDict[i];

                }
            }
            Console.WriteLine("Most frequent: " + ans);

        }
    }
}
