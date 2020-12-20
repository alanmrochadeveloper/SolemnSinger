namespace solemnsinger.Models
{
    public class UserModifications :JunctionModelBase
    {

        public User User { get; set; }
        public long UserId { get; set; }

        public Modification Modification { get; set; }
        public long ModificationId { get; set; }
    }
}