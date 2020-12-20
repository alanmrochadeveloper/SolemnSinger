namespace solemnsinger.Models
{
    public class CategoryModifications : JunctionModelBase
    {
        public Category Category { get; set; }
        public long CategoryId { get; set; }
        
        public Modification Modification { get; set; }
        public long ModificationId { get; set; }


    }
}