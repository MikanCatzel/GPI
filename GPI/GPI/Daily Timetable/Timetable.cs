using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPI
{
    // this class is going to sort out where the events go during day
    // - intercepts with the main events
    // - intercepts with the daily events with each other
    class Timetable : Events
    {
        // storing all the events in this list
        public List<EventInfo> allEvents = new List<EventInfo>();   // need to get the events from the xml file

        // when creating a timetable, add in the events
        public Timetable(EventInfo[] addedEvents)
        {
            foreach (EventInfo e in addedEvents)
            {
                allEvents.Add(e);
            }
            //// add all the main events to allEvents list
            //for (int i = 0; i < addedEvents.allMainEvents.Count(); i++)
            //    allEvents.Add(addedEvents.allMainEvents[i]);
            //// add all the daily events to allEvents list
            //for (int i = 0; i < addedEvents.allDailyEvents.Count(); i++)
            //    allEvents.Add(addedEvents.allDailyEvents[i]);
        }
    }
}
