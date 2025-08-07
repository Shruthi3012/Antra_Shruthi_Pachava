using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class GroceryList
    {
        public static void groceryList()
        {
            List<string> gList = new List<string>();
            while(true)
            {
                string item = Console.ReadLine();
                if (item.Equals("--"))
                    gList.Clear();
                else if (item.StartsWith('+'))
                {
                    item = item.Replace("+", "");
                    gList.Add(item);
                   
                }
                else if (item.StartsWith('-'))
                {
                    item = item.Replace("-", "");
                    gList.Remove(item);
                }
                else
                {
                    break;
                }
                Console.WriteLine(string.Join(", ", gList));
            }
        }
    }
}
