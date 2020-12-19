using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace solemnsinger.Models
{
    public class Contract : ModelBase
    {
        public Customer Customer { get; set; }
        public long CustomerId { get; set; }

        public Location EventLocation { get; set; }
        public long LocationId { get; set; }

        public Term Term { get; set; }// its a term with many rules
        public long TermId { get; set; }

        public string PrintableContract { get; set; }//a string version of contract which can be printable

        public byte[] DigitalContract { get; set; }// if wish to save its digitalized version which customer signature. OFC Optional

        [Column(TypeName = "decimal(8,2)")]
        public decimal TotalPrice { get; set; }
    }
}
