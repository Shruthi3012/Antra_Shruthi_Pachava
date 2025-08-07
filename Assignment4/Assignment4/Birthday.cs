using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class Birthday
    {
       public static void DaysOld()
        {
            DateTime bdate = new DateTime(2001, 06, 12);
            int days = (DateTime.Today - bdate).Days; 
            Console.WriteLine("Days old: " + days);
            int daysToNextAnniversary = 10000 - (days % 10000);
            DateTime nextDate = DateTime.Today.AddDays(daysToNextAnniversary);
            Console.WriteLine("10,000 day Anniversary : " + nextDate);
        }
    }
}
