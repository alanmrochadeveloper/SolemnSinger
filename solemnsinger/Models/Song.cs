using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace solemnsinger.Models
{
    public class Song: ModelBase
    {
        public string Name { get; set; }

        public SongSinger SongSinger { get; set; }
        public long SongSingerId { get; set; }
        public string Part { get; set; } //which part of the solemn event the song will be sang by singer, optional ofc

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        public IEnumerable<ContractSongsJunction> ContractSongs { get; set; }
    }
}
