using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solemnsinger.Models
{
    public class SongSinger : ModelBase
    {
        public string Name{ get;set;}
        public IEnumerable<Song> Songs { get; set; }
    }
}
