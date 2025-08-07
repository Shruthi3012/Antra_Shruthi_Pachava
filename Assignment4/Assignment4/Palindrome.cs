using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class Palindrome
    {
        public static void extractpalindrome()
        {
            Console.WriteLine("Enter a sentence: ");
            string str = Console.ReadLine();
            string[] words = Regex.Split(str, @"\W+");
            SortedSet<string> hset = new SortedSet<string>();
            foreach (string word in words)
            {
                bool isPlaindrome = true;
                int i = 0;
                int j = word.Length-1;
                while(i <= j)
                 {
                    if (word[i] == word[j])
                    {
                        i++;
                        j--;
                    }
                    else
                    {
                        isPlaindrome = false;
                        break;
                    }
                }
                if(isPlaindrome)
                    hset.Add(word);

            }
            
            Console.WriteLine(string.Join(", ", hset));
        }
    }
}
