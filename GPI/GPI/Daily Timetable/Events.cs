using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPI
{
    public class Events
    {

        protected EventInfo DailyEvent(string name, DateTime startTime, DateTime endTime)
        {
            EventInfo e = new EventInfo(name, startTime, endTime);
            return e;
        }

        protected void MainEvent()
        {

        }
    }
}
