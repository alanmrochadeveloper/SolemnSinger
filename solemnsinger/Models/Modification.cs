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
        public AccessLevelModifications AccessLevelModifications { get; set; }
        public CalendarModifications CalendarModifications { get; set; }
        public CategoryModifications CategoryModifications { get; set; }
        public ContractModifications ContractModifications { get; set; }
        public CustomerModifications CustomerModifications { get; set; }
        public LocationModifications LocationModifications { get; set; }
        public RuleModifications RuleModifications { get; set; }
        public SongModifications SongModifications { get; set; }
        public SongSingerModifications SongSingerModifications { get; set; }
        public TermModifications TermModifications { get; set; }
        public UserModifications UserModifications { get; set; }
    }
}
