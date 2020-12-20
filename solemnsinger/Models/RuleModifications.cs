namespace solemnsinger.Models
{
    public class RuleModifications : JunctionModelBase
    {
        public Rule Rule { get; set; }
        public long RuleId { get; set; }

        public Modification Modification { get; set; }
        public long ModificationId { get; set; }
    }
}