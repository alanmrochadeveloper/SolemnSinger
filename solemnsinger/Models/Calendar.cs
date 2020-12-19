using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solemnsinger.Models
{
    public class Calendar : ModelBase
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool AllDay { get; set; }

        public Location Location { get; set; }
        public long LocationId { get; set; }

        public Category Category { get; set; }
        public long CategoryId { get; set; }
        public string CategorySuggestion { get; set;}//in case there is not a pre recorded category available, then the customer can suggest one
    }
}
