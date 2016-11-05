using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPI
{
    public class EventInfo
    {
        public string name;
        public DateTime startTime;
        public DateTime endTime;
        
        public EventInfo(string _name, DateTime _startTime, DateTime _endTime)
        {
            _name = name;
            _startTime = startTime;
            _endTime = endTime;
        }
    }
}
