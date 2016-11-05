using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPI
{
    class Timetable : Events
    {
        // storing all the daily events in this list
        public List<EventInfo> allDailyEvents = new List<EventInfo>();

        // add a daily event
        public void AddEvent(string title, string startTime, string endTime)
        {
            // start time conversion to dateTime
            DateTime st = DateTime.Parse(startTime);
            // end time conversion to dateTime
            DateTime et = DateTime.Parse(endTime);

            allDailyEvents.Add(DailyEvent(title, st, et));
        }
        // add a daily event without a end time
        public void AddEvent(string title, string startTime)
        {
            // start time conversion to dateTime
            DateTime st = DateTime.Parse(startTime);
            // end time equals start time plus 1 hour
            DateTime et = st.AddHours(1);

            allDailyEvents.Add(DailyEvent(title, st, et));
        }

        // add a main event
        public void AddEvent(string title, string description, string location, string startTime, string endTime)
        {
            // start time conversion to dateTime
            DateTime st = DateTime.Parse(startTime);
            // end time conversion to dateTime
            DateTime et = DateTime.Parse(endTime);

            allDailyEvents.Add(MainEvent(title, description, location, st, et));
        }
        // add a main event without a end time
        public void AddEvent(string title, string description, string location, string startTime)
        {
            // start time conversion to dateTime
            DateTime st = DateTime.Parse(startTime);
            // end time equals start time plus 1 hour
            DateTime et = st.AddHours(1);

            allDailyEvents.Add(MainEvent(title, description, location, st, et));
        }
    }
}
