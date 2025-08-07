using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class Greetings
    {
       public static void DayGreetings()
        {
            DateTime dtime = DateTime.Now;
            TimeSpan morning = new TimeSpan(3, 0, 0);
            TimeSpan afternoon = new TimeSpan(12, 0, 0);
            TimeSpan evening = new TimeSpan(17, 0, 0);
            TimeSpan night = new TimeSpan(20, 0, 0);
            if (dtime.TimeOfDay > morning && dtime.TimeOfDay < afternoon)
                Console.WriteLine("Good Morning");
            else if (dtime.TimeOfDay > afternoon && dtime.TimeOfDay < evening)
                Console.WriteLine("Good Afternoon");
            else if (dtime.TimeOfDay > evening && dtime.TimeOfDay < night)
                Console.WriteLine("Good Evening");
            else if (dtime.TimeOfDay > night || dtime.TimeOfDay < morning)
                Console.WriteLine("Good Night");
        }
    }
}
