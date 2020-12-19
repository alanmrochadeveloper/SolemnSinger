using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solemnsinger.Models
{
    public class Customer: ModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RG { get; set; }//brazilian ID
        public string CPF { get; set; }//brazilian SSN
        public string CNPJ { get; set; } //brazilian SSN for companies

        public IEnumerable<Contract> Contracts { get; set; }

        public Location Location { get; set; }
        public long LocationId { get; set; }
    }
}
