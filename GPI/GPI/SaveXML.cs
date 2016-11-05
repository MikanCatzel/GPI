using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GPI
{
    public class SaveXML
    {
        static string XMLfilePath = "Timetable.xml";
         
        public void WriteToXML (List<EventInfo> _allEvents)
        {
            
        }

        public List<EventInfo> ReadEventsFromXML ()
        {
            List<EventInfo> allEvents = new List<EventInfo>();

            using(XmlReader reader = XmlReader.Create(XMLfilePath))
            {
                while(reader.ReadToFollowing("EventInfo"))
                {
                    string title = reader.GetAttribute("Title");
                    DateTime startTime = DateTime.Parse(reader.GetAttribute("Date:Start"));
                    DateTime endTime = DateTime.Parse(reader.GetAttribute("Date:End"));

                    string location = reader.GetAttribute("Location");

                    allEvents.Add(new EventInfo(title, startTime, endTime));

                    //This is for if the event was in the past
                    /*
                    if(date.CompareTo(DateTime.Now) != -1)
                    {
                        allEvents.Add(new EventInfo(
                    }
                    else
                    {
                        Console.WriteLine($"    :Event '{title}' has already passed: not added to event list.");
                    }*/
                }
            }

            return allEvents;
        }
        /*
        public void WriteEventToXML (List<EventInfo> _allEvents)
        {
            try
            {
                //Create settings for XML file
                XmlWriterSettings XMLsettings = new XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = "    ",
                    NewLineChars = "\r\n",
                    NewLineOnAttributes = true,
                    NewLineHandling = NewLineHandling.Replace
                };

                using(XmlWriter writer = XmlWriter.Create(XMLfilePath, XMLsettings))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Events");

                    foreach(EventInfo e in _allEvents)
                    {
                        writer.WriteStartElement("EventInfo");

                        writer.WriteAttributeString("Title", e.Title);
                        writer.WriteAttributeString("Date", e.Date.ToString());

                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }

                Console.WriteLine("\nEvent added: " + events.Last<Event>().Title + "\nDate: " + events.Last<Event>().Date);
            }
            catch
            {
                Console.WriteLine("Could not parse date, please try again.\nFormat: DD/MM/YYYY 12:00pm");
            }
        }
        */
    }
}
