using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPI
{
    public class EventInfo
    {
        // general event info
        public string title;
        public string description;
        public string location;
        public DateTime startTime;
        public DateTime endTime;
        
        // not sure why I need this - comes up with error in Events.cs
        public EventInfo()
        {

        }
        // for a basic event, use this constructor
        public EventInfo(string _title, DateTime _startTime, DateTime _endTime)
        {
            title = _title;
            startTime = _startTime;
            endTime = _endTime; // doesn't have to have an endTime - just add 1 hour if not added
        }
        // for a main event, use this constructor
        public EventInfo(string _title, string _description, string _location, DateTime _startTime, DateTime _endTime)
        {
            title = _title;
            description = _description;
            location = _location;
            startTime = _startTime;
            endTime = _endTime;
        }
    }
}
