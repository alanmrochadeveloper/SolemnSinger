using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solemnsinger.Models
{
    public class ModelBase
    {
        public long Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime LastTimeModified { get; set; }
        
        public IEnumerable<Modification> Modifications { get; set; }
    }
}
