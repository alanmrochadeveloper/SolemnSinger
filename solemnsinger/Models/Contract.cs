using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace solemnsinger.Models
{
    public class Contract : ModelBase
    {
        public Customer Customer { get; set; }
        public long CustomerId { get; set; }

        //below event location properties
        public string PartyHallName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string CEP { get; set; } //Brazilian CEP
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Term Term { get; set; }// its a term with many rules
        public long TermId { get; set; }

        public string PrintableContract { get; set; }//a string version of contract which can be printable

        public byte[] DigitalContract { get; set; }// if wish to save its digitalized version which customer signature. OFC Optional

        [Column(TypeName = "decimal(8,2)")]
        public decimal TotalPrice { get; set; }

        public IEnumerable<ContractSongsJunction> ContractSongs { get; set; }
        public Calendar Calendar { get; set; }
        public long CalendarId { get; set; }

        
    }
}
