using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solemnsinger.Models
{
    public class Rule :ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<Term> Terms { get; set; }

        public IEnumerable<RuleModifications> RuleModifications { get; set; }
    }
}
