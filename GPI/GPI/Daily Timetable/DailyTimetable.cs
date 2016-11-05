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
        public void AddEvent(string name, string startTime, string endTime)
        {
            // start time conversion to dateTime
            DateTime st = DateTime.Parse(startTime);
            // end time conversion to dateTime
            DateTime et = DateTime.Parse(endTime);

            allDailyEvents.Add(DailyEvent(name, st, et));
        }
    }
}
