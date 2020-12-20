using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solemnsinger.Models
{
    public class ContractSongsJunction
    {
        public long Id { get; set; }

        public Contract Contract { get; set; }
        public long ContractId { get; set; }

        public Song Song { get; set; }
        public long SongId { get; set; }
    }
}
