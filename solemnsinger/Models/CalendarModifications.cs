using System.Collections.Generic;

namespace solemnsinger.Models
{
    public class CalendarModifications : JunctionModelBase
    {
        public Calendar Calendar { get; set; }
        public long CalendarId { get; set; }

        public Modification Modification { get; set; }
        public long ModidicantionId { get; set; }
    }
}