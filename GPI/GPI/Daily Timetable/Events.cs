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
        protected EventInfo DailyEvent(string name, DateTime startTime, DateTime endTime)
        {
            EventInfo e = new EventInfo(name, startTime, endTime);
            return e;
        }

        // main events creation, returns the eventInfo
        protected EventInfo MainEvent(string name, string description, DateTime startTime, DateTime endTime)
        {
            EventInfo e = new EventInfo(name, description, startTime, endTime);
            return e;
        }
    }
}
