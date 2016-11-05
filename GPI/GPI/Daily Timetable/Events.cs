using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPI
{
    public class Events
    {
        // daily events during the day, returns the eventInfo
        protected EventInfo DailyEvent(string title, DateTime startTime, DateTime endTime)
        {
            EventInfo e = new EventInfo(title, startTime, endTime);
            return e;
        }

        // main events creation, returns the eventInfo
        protected EventInfo MainEvent(string title, string description, string location, DateTime startTime, DateTime endTime)
        {
            EventInfo e = new EventInfo(title, description, location, startTime, endTime);
            return e;
        }
    }
}
