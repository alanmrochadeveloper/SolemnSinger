namespace solemnsinger.Models
{
    public class SongModifications : JunctionModelBase
    {
        public Song Song { get; set; }
        public long SongId { get; set; }

        public Modification Modification { get; set; }
        public long ModificationId { get; set; }
    }
}