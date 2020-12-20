namespace solemnsinger.Models
{
    public class TermModifications : JunctionModelBase
    {
        public Term Term { get; set; }
        public long TermId { get; set; }

        public Modification Modification { get; set; }
        public long ModificationId { get; set; }
    }
}