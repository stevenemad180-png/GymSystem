namespace gym.Models.Entities
{
    public class BaseMember
    {
       public int Id { get; set; } 
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
    }
}
