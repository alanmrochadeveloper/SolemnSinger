using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solemnsinger.Models
{
    public class Location: ModelBase
    {
        public string LineAddress1 { get; set; }
        public string LineAddress2 { get; set; }
        public string CEP { get; set; } //brazilian ZIP
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Customer Customer { get; set; }

        public Contract Contract { get; set; }
        
    }
}
