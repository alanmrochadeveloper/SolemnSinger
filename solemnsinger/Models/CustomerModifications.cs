namespace solemnsinger.Models
{
    public class CustomerModifications :JunctionModelBase
    {
        public Customer Customer { get; set; }
        public long CustomerId { get; set; }

        public Modification Modification { get; set; }
        public long ModificationId { get; set; }
    }
}