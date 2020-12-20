namespace solemnsinger.Models
{
    public class SongSingerModifications : JunctionModelBase
    {
        public SongSinger SongSinger { get; set; }
        public long SongSingerId { get; set; }

        public Modification Modification { get; set; }
        public long ModificationId { get; set; }
    }
}