namespace solemnsinger.Models
{
    public class ContractModifications : JunctionModelBase
    {
        public Contract Contract { get; set; }
        public long ContractId { get; set; }

        public Modification Modification { get; set; }
        public long ModificationId { get; set; }
    }
}