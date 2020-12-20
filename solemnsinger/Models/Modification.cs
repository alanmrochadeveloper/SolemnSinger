using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solemnsinger.Models
{
    public class Modification
    {
        public long Id { get; set; }
        public DateTime ModifiedAt { get; set; } // when modified
        public long UserId { get; set; } // who modified
        public IEnumerable<AccessLevelModifications> AccessLevelModifications { get; set; }
        public IEnumerable<CalendarModifications> CalendarModifications { get; set; }
        public IEnumerable<CategoryModifications> CategoryModifications { get; set; }
        public IEnumerable<ContractModifications> ContractModifications { get; set; }
        public IEnumerable<CustomerModifications> CustomerModifications { get; set; }
        public IEnumerable<LocationModifications> LocationModifications { get; set; }
        public IEnumerable<RuleModifications> RuleModifications { get; set; }
        public IEnumerable<SongModifications> SongModifications { get; set; }
        public IEnumerable<SongSingerModifications> SongSingerModifications { get; set; }
        public IEnumerable<TermModifications> TermModifications { get; set; }
        public IEnumerable<UserModifications> UserModifications { get; set; }
    }
}
