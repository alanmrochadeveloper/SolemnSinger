using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solemnsinger.Models
{
    public class User : ModelBase
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public AccessLevel AccessLevel { get; set; }

        public Customer Customer { get; set; }
        public long CustomerId { get; set; }
    }
}
