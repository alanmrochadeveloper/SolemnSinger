namespace solemnsinger.Models
{
    public class LocationModifications : JunctionModelBase
    {
        public Location Location { get; set; }
        public long LocationId { get; set; }

        public Modification Modification { get; set; }
        public long ModificationId { get; set; }
    }
}