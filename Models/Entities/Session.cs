namespace gym.Models.Entities
{
    public class Session : BaseMember
    {

        public int capacity { get; set; }
        public string Description { get; set; } = default!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

// ONE TO MANY 
         public trainer trainer { get; set; } = default!;
        public int trainerId { get; set; }

    }

}
    
