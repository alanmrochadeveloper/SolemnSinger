namespace solemnsinger.Models
{
    public class AccessLevelModifications: JunctionModelBase
    {
         
        public AccessLevel AccessLevel { get; set; }
        public long AccessLevelId { get; set; }

        public Modification Modification { get; set; }
        public long ModificationId { get; set; }
    }
}