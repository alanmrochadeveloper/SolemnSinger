using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solemnsinger.Models
{
    public class Category: ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Calendar> Calendars { get; set; }

        
    }
}
