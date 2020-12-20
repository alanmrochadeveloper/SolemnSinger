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
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string CEP { get; set; } //Brazilian CEP
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }


        public IEnumerable<Contract> Contracts { get; set; }
        
        public User User { get; set; }
        
    }
}
