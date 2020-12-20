using System.Collections.Generic;

namespace solemnsinger.Models
{
    public class Term : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<Rule> Rules { get; set; }
        public IEnumerable<Contract> Contracts { get; set; }

        
    }
}