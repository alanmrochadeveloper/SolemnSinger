namespace solemnsinger.Models
{
    public class AccessLevel : ModelBase
    {
        public string Name { get; set; }

        public bool Create { get; set; }
        public bool Read { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }

        public User User { get; set; }
        public long UserId { get; set; }
    }
}