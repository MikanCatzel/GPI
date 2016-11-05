using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPI
{
    class DailyTimetable : Events
    {
        // storing all the daily events in this list
        public List<EventInfo> allDailyEvents = new List<EventInfo>();

        // add a daily event
        public void AddEvent()
        {
            allDailyEvents.Add(DailyEvent("Lunch", DateTime.Today, new DateTime(2015, 8, 14)));
            Console.WriteLine(allDailyEvents[0].name);
        }
    }
}
