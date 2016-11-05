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
        public string name;
        public string description;
        public DateTime startTime;
        public DateTime endTime;
        
        // for a basic event, use this constructor
        public EventInfo(string _name, DateTime _startTime, DateTime _endTime)
        {
            name = _name;
            startTime = _startTime;
            endTime = _endTime;
        }
        // for a main event, use this constructor
        public EventInfo(string _name, string _description, DateTime _startTime, DateTime _endTime)
        {
            name = _name;
            description = _description;
            startTime = _startTime;
            endTime = _endTime;
        }
    }
}
