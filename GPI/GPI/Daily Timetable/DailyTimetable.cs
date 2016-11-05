using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPI
{
    class DailyTimetable : Events
    {
        List<EventInfo> allDailyEvents = new List<EventInfo>();

        void AddEvent()
        {
            allDailyEvents.Add(base.DailyEvent("Lunch", DateTime.Today, new DateTime(2015, 8, 14)));
            Console.WriteLine(allDailyEvents[0].name);
        }
    }
}
